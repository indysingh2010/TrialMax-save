#!perl
#############################################################################
# ObjReportExcel.pl 
#
#   Copyright (c) 2005-2021, FTI Consulting, Inc. All rights reserved.
#
#   USAGE:
#	perl FTIORE.pl -in=C:\Users\David\AppData\Local\Temp\_tmax_ore_files_\tmax_ore_setup.xml
#
#   CHANGE LOG:
#   Updated 2021-06-034 by Indy Singh support@indigostar.com
#   Updated version number and usage comment
#   Version number 1.0.31 -> 1.0.32
#   Replace broken use Win32::OLE::Const with explict definitions of used values as Perl functions
#   Change default excel file extension from xls to xlsx
#   Fix failure if missing HKLM\Software\FTIORE key
#   Fix progress counter. It counts to to about 4000 instead of 100
#   - variable $is used to count number of designations, but $i gets clobbered before it is used.
#
#############################################################################
$version = "1.0.32 ";	# change have to change below, not variable replacement in comment lines
use Getopt::Long;
use Win32::ODBC;
use Win32::OLE;
use File::Copy;
use File::Path;
use File::stat;
use Win32;
use win32::GUI;
use MIME::Base64;
use Win32::OLE;
use Win32::OLE::Variant;
use Win32::OLE qw(in with);
use Win32::OLE::Variant;
use Win32::OLE::Const;
use Archive::Zip qw( :ERROR_CODES :CONSTANTS );
use Win32API::File 0.09 qw( :ALL );
use Win32::Registry;

# ISFIX BEGIN
#use Win32::OLE::Const 'Microsoft Excel';		#Obsolete fails
#use Win32::OLE::Const 'Microsoft Word';		#Obsolete fails
#perl2exe_include "Tie/Handle.pm"
#perl2exe_include "Time/HiRes.pm"
use XML::Parser;
#perl2exe_bundle "libgcc_s_seh-1.dll"
#perl2exe_bundle "libwinpthread-1.dll"
#perl2exe_bundle "libstdc++-6.dll"
#perl2exe_bundle "libexpat-1__.dll"
my $xlApp = Win32::OLE->new('Excel.Application', 'Quit') || die "Can't create Excel App: ", Win32::OLE->LastError; 
my $xl_constants = Win32::OLE::Const->Load($xlApp);
my $wdApp = Win32::OLE->new('Word.Application', 'Quit') || die "Can't create Word App: ", Win32::OLE->LastError; 
my $wd_constants = Win32::OLE::Const->Load($wdApp);

# instead of importing all possible variables as functions, define just the ones we need as subs
sub xlEdgeLeft { return ${ $xl_constants }{xlEdgeLeft}; }
sub xlEdgeRight { return ${ $xl_constants }{xlEdgeRight}; }
sub wdHeaderFooterPrimary { return ${ $wd_constants }{wdHeaderFooterPrimary}; }
# ISFIX END


my $OfficeRegKey2007 = "SOFTWARE\\Microsoft\\Office\\12.0";
my $OfficeRegKey2010 = "SOFTWARE\\Microsoft\\Office\\13.0";
my $hkey;
my $isXLSX = 1;		# IS FIX 21-06-03 was 0 future proof the code to use xlsx extension by default

#perl2exe_info CompanyName=FTI Consulting Inc.
#perl2exe_info FileDescription=TrialMax Object Report Engine
#perl2exe_info FileVersion=1.0.31
#perl2exe_info ProductVersion=1.0.31
#perl2exe_info LegalCopyright=Copyright © 2007-2010, FTI Consulting, Inc. All rights reserved.
#perl2exe_info LegalTrademarks=TrialMax® is a registered tradmark of FTI Consulting, Inc.
#perl2exe_info ProductName=FTIORE
#perl2exe_info FileDescription=

#
# If the Office version is 2007 or 2010 then use the xlsx externtion
# IS FIX 21-06-03 this is obsolete
#
if ( $HKEY_LOCAL_MACHINE->Open($OfficeRegKey2007,$hkey) ) {
	$hkey->Close();
	$isXLSX = 1;
} 
if ( $HKEY_LOCAL_MACHINE->Open($OfficeRegKey2010,$hkey) ) {
	$hkey->Close();
	$isXLSX = 1;
} 



		#
		# Get Suppress Duplicate flag from the registry
		#
	$Register = "Software\\FTIORE\\SUPRESSDUP";
	$regSupressDup = 0;

	if ( $HKEY_LOCAL_MACHINE->Open($Register,$hkey) ) {
		$hkey->QueryValue($subkey,$value);
		$hkey->Close();
		if ($value eq '')
		{
			$regSupressDup = 0	
		}
		else
		{
			$regSupressDup = $value ; 
		}
	} else {	
		#$HKEY_LOCAL_MACHINE->Open("Software\\FTIORE",$hkey)|| die $!;
		#$hkey->SetValue("SUPRESSDUP",REG_SZ,"0");
		#$hkey->Close();		
	    # IS FIX 21-06-03 ignore error if regkey does not exist
		if ($HKEY_LOCAL_MACHINE->Open("Software\\FTIORE",$hkey)) {
		    $hkey->SetValue("SUPRESSDUP",REG_SZ,"0");
		    $hkey->Close();
		}
	} 


GetOptions ( "verbose" => \$verbose, "help" => \$help,"version" => \$versionp, 'in=s' => \$xmlconfigname);
usage() if $help;
showversion() if $versionp;


#
# Try for Perl2exe
#
use XML::NamespaceSupport; # uncomment for P2x binary
use XML::Parser::Style::Tree; # uncomment for P2x binary
use bytes; # uncomment for P2x binary
use File::Glob ':glob'; # uncomment for P2x binary
#perl2exe_include "utf8_heavy.pl";
#perl2exe_include "unicore/To/Lower.pl";
#perl2exe_include "unicore/To/Upper.pl";
#perl2exe_include "unicore/To/Fold.pl";
#perl2exe_include "Encode/Unicode.pm";



if ( length($xmlconfigname) < 1 ) {
  	$res = Win32::MsgBox( "XML config file not specified." , 0, "Obection Report Engine Error" );
    	exit(1);
}
	#
	# Misc Constants
	#

    $xlHAlignCenter = 0xFFFFEFF4;
    $xlVAlignTop = 0xFFFFEFC0;
    $xlTop = 0xFFFFEFC0;
    
    $xlContinuous = 1;
    $xlHairline = 1;
    $xlMedium = 0xFFFFEFD6;
    $xlThick = 4;
    $xlThin = 2;
    $xlnone = 0;
        #
        #  Borders
        #
    $xlInsideHorizontal = 12;
    $xlInsideVertical = 11;
    $xlDiagonalDown = 5;
    $xlDiagonalUp = 6;
    $xlEdgeBottom = 9;
    $xlEdgeLeft = 7;
    $xlEdgeRight = 10;
    $xlEdgeTop = 8;
    
        #
        # Data Series
        #
    $xlColumns = 2;
    $xlLinear = 0xFFFFEFDC;
	#
	# Word Settings
	#
    $wdHeaderFooterPrimary = 1;
 
    

    no strict "refs";
    require XML::Simple;
    $ENV{XML_SIMPLE_PREFERRED_PARSER} = 'XML::Parser';
    $PREFERRED_PARSER = 'XML::Parser';

    $lc;	# was my
    $xs = new XML::Simple();	# was my

	#
	# Read the confiuguration file
	#
    #print "Reading CONFIGXML file = " . $xmlconfigname . "\n";
    $xmlc = $xs->XMLin("$xmlconfigname", ForceArray => 1,SuppressEmpty => 0);	
    #print "Done Reading \n";
	


	#use Data::Dumper;
	#print OUTF "Dumper= " . Dumper($xmlc) . "\n"; 
	#close (OUTF);
	#exit;

    $reportFormat = getConfigParam( $xmlc, "reportFormat", "noDefault" );
    	# or new format "Transcript-Excel" 
    if ( ($reportFormat ne "Script-Excel") && ($reportFormat ne "Designation-Word") && ($reportFormat ne "Transcript-Excel") ) {
  	$res = Win32::MsgBox( "Unsupported report format: $reportFormat" , 0, "Obection Report Engine Error" );
	exit(1);
    }
    $xmlsPath = getConfigParam( $xmlc, "xmlsPath", "" );
    if ( length( $xmlsPath ) < 1 ) {
  	$res = Win32::MsgBox( "Path to XMLS file not defined." , 0, "Obection Report Engine Error" );
    	exit(1);
    } 
    if ( ! -e $xmlsPath ) {
  	$res = Win32::MsgBox( "XMLS file $xmlsPath not found" , 0, "Obection Report Engine Error" );
	exit(1);
    }



	#
	# Define Globals
	#
    my @keyarray ;	# hold the keys in array, loop against later
    my %mediaIdNameLookup;

	#
	# DBM: 8/31/2010 Create a hash of objections that are already output. Suppress re-print of the same obj
	# 
    my %objectionsIdentified = ();

	#
	# DBM: 2/21/09  Pre-process the xmls file to force unique designation names in the "name".
	# perl hash entries are overridden otherwise
	#
	
    	$xmlsPathProcessed = "$xmlsPath" . "_proc.xmls" ;
	unless (open (OUTF, ">$xmlsPathProcessed"  ) )
	{
		print "Error opening $xmlsPathProcessed\n";
		exit(-1);

	}
	unless (open (INF, "<$xmlsPath"  ) )
	{
		print "Error opening $xmlsPath\n";
		exit(-1);

	}
	unless ( @mydata = <INF> ) { print "Error reading $xmlsPath\n"; }
	close INF;

	my @nameArr;

	#my $i = 0;  # IS FIX
	my $nbDesignations = 0;
	$nbMediaIDs = 0;
	foreach (@mydata) {
			#
			# Force each designation name string to be unique
			#
		if ( /.*\<designation name=\"(.*?)\".*/ ) {
		     $from = $1;
		     $to = $1 . "_+" . $nbDesignations;
		     s/$from/$to/;	
		} 
		print OUTF $_;
		
	
		if ( /.*\<designation name=\"(.*?)\".*/ ) {
			$keyarray[$nbDesignations++] = $1;	
		}
			# <deposition mediaId="Curfman_G_20060124" name="Curfman 01/24/2006"
		if ( /.*\<deposition mediaId=\"(.*?)\".*name=\"(.*?)\".*/ ) {
			$mediaIdNameLookup{"$1"} = $2;
			$nameArr[$nbMediaIDs++] = $2;
		}	
	}
	close OUTF;
	
	 


	#
	# Variables to Pull from XML config file
	#
	
    $saveAsName = getConfigParam( $xmlc, "saveAs", "" );
    if ( $isXLSX ) {
    	$saveAsName =~ s/\.xls/\.xlsx/g;
    }
    
    if ( length( $saveAsName ) < 1 ) {
  	$res = Win32::MsgBox( "SaveAs Path not defined." , 0, "Obection Report Engine Error" );
    	exit(1);
    }	
    if ( -e $saveAsName ) {
  	#$res = Win32::MsgBox( "File $saveAsName already exists." , 0, "Obection Report Engine Error" );
    	#exit(1);
    	unlink($saveAsName);
    }		
    $progressFile = getConfigParam( $xmlc, "progressFile", "" ); 
    $donePercent = 0;
    $visible = getConfigParam( $xmlc, "visible", 0 ); 
    $title = getConfigParam( $xmlc, "title", "" ); 
    $leftMargin = getConfigParam( $xmlc, "leftMargin", .25 ); 
    $rightMargin = getConfigParam( $xmlc, "rightMargin", .25 );    
    $topMargin = getConfigParam( $xmlc, "topMargin", .25 );
    $bottomMargin = getConfigParam( $xmlc, "bottomMargin", .25 );
    $headerMargin = getConfigParam( $xmlc, "headerMargin", .25 );    
    $footerMargin = getConfigParam( $xmlc, "footerMargin", .25 );    
    $showObjection = getConfigParam( $xmlc, "showObjection", 1 ); 
    $showRuling = getConfigParam( $xmlc, "showRuling", 1 );
    $splitResponse = getConfigParam( $xmlc, "splitResponse", 0 );
    $shortCaseName = getConfigParam( $xmlc, "shortCaseName", "ShortCaseName" );    
    $longCaseName = getConfigParam( $xmlc, "longCaseName", "longCaseName" );
    $selectedDeponent = getConfigParam( $xmlc, "selectedDeponent", "selectedDeponent" );
    $pltfColor = getConfigParam( $xmlc, "pltfColor", "255,0,0" );   
    $defColor = getConfigParam( $xmlc, "defColor", "0,0,255" );    
    $zoom = getConfigParam( $xmlc, "zoom", 95 );

#print "Zoom=$zoom\n";
$zoom = int($zoom);
  
    
    $DesigColor1 = getConfigParam( $xmlc, "DesigColor1", "0,0,255" );
    $DesigColor2 = getConfigParam( $xmlc, "DesigColor2", "255,0,0" );
    $DesigColor3 = getConfigParam( $xmlc, "DesigColor3", "0,255,0" );
    $DesigColor4 = getConfigParam( $xmlc, "DesigColor4", "139,0,139" );
    $DesigColor5 = getConfigParam( $xmlc, "DesigColor5", "206,238,206" );	# 238
    $DesigColor6 = getConfigParam( $xmlc, "DesigColor6", "238,130,238" );
    $DesigColor7 = getConfigParam( $xmlc, "DesigColor7", "255,165,0" );  
    
    $showComment = getConfigParam( $xmlc, "showComment", 0 );
    $commentHeader = getConfigParam( $xmlc, "commentHeader", "Comment" );
    
   
   
    for ( $i=1; $i<=7; $i++ ) {
	$mycolor = "DesigColor" . $i ;

	if ( defined( $xmlc->{'configure'}->{"$mycolor"} ) ) {
		$partys[$i] = $xmlc->{'configure'}->{"$mycolor"}->{'party'};
	} else {
			# odd defaults to defense; even plaintiff
		if ( ($i % 2) > 0 ) {	
			$partys[$i] = "D";
		} else {
			$partys[$i] = "P";
		}
	}
    }
    
    	# was my
    @DesigColors = ("0,0,0","$DesigColor1","$DesigColor2","$DesigColor3","$DesigColor4","$DesigColor5","$DesigColor6","$DesigColor7");

	#
	# Define Globals
	#
    #my @keyarray ;	# hold the keys in array, loop against later
    #my %mediaIdNameLookup;

    WriteProgress(1);

	#
	# DBM: 02/21/09 Force unique designation names
	#
	
    eval {
        $xmld = $xs->XMLin("$xmlsPathProcessed", ForceArray => 1,SuppressEmpty => 0);	#  was ForceArray => ["link"]
    };
	#    $xmld = $xs->XMLin("$xmlsPath", ForceArray => 1,SuppressEmpty => 0);	#  was ForceArray => ["link"]

	#
	# If there's an error then find the objection that it applies to.
	#
    if ( $@ ) {
 
    	
	$_ =  $@;
	if ( /reference to invalid character number at line (\d+)\, column (\d+)/ ) {
		my $errLine;  
		my $errColumn;
		my $msgStr;
		my $plStr;
		my $maxLine;
		
	    print "invalid character at line $1 and column $2\nin file $xmlsPathProcessed\n";
	    
	    	$errLine = $1;
	    	$errColumn = $2;
	    	
		open (INFe, "<$xmlsPathProcessed"  );
		@myErrData = <INFe>;
		close INFe;

		$maxLine = scalar(@myErrData);
			# get the page line info
		if ( $errLine > 0 && $errLine <= $maxLine ) {
			$_ = $myErrData[$errLine-1];
			if ( /.*firstPL=\"(\d+)\" lastPL=\"(\d+)\"/ ) {
				$startPg = int($1 / 100);
				$startLn = $1 % 100;
				$endPg = int($2 / 100);
				$endLn = $2 % 100;
				
				$plStr = "$startPg\:$startLn-$endPg\:$endLn";
			} else {
				$plStr = "Can\'t find page line";
			}
		
		
			$msgStr = substr($myErrData[$errLine-1], $errColumn-24, 40 ) . "\n";	#------------------------^\n
		
		} else {
			$msgStr = "Invalid Line number $errLine.  Max is $maxLine"
		}
		print "$msgStr	\n";
		
		$res = Win32::MsgBox( "Error in XML at line $errLine and column $errColumn\n\nIn Objection\: $plStr\n\nNear\:\n$msgStr" , 0, "Obection Report Engine Error" );
		
		
		exit(255) ;
	}

	$res = Win32::MsgBox( "error in XML file $xmlsPathProcessed\n $@" , 0, "Obection Report Engine Error" );
    	exit(255);
    }

    WriteProgress(2);
    
    if ( 0 ) {
	unless (open (OUTF, ">foo.txt"  ) )
	{
		print "Error opening foo.txt\n";
		exit(-1);

	}
	use Data::Dumper;
	print OUTF "Dumper= " . Dumper($xmld) . "\n"; 	
	close(OUTF);
	exit;	
   }
	
   if ($reportFormat eq "Script-Excel" || $reportFormat eq "Transcript-Excel") {
	
   	printExcelHeader();
   }

   if ($reportFormat eq "Designation-Word") {
   
   	printWordHeader();
   }
	#
	# Get the script name, this'll be a key in the hash structure
	#
$scriptName = (keys (%{$xmld->{'script'}}))[0];

if ($reportFormat eq "Script-Excel" || $reportFormat eq "Transcript-Excel" ) {
	$lineNb = 10;
} else {
	$lineNb = 1;

}
$desigNb = 1;
$lc =0;	# track the excel lines with objection text.

	#
	# A quick hack to for the designation to be in the correct order
	#
	
$starttime = localtime;


WriteProgress(3);

if ( $reportFormat eq "Transcript-Excel") {
	doTranscriptExcel();
	exit;
}
 

# $nbDesignations = $i;  # IS FIX
if ( $nbDesignations < 1 ) { $nbDesignations = 1; }

$lastPrimaryId = "";
$sectionNb = 1;

$count = 0;	# keep track of the % complete
foreach $key (@keyarray) {
   $count++;
   if ( ($count%10)==0 ) {
	   if ($reportFormat eq "Script-Excel") {
		$donePercent = 4 +  ( (46*$count)/$nbDesignations );
	   } else {
		$donePercent = 4 +  ( (96*$count)/$nbDesignations );
	   }
	   WriteProgress($donePercent);	
   }
	

	# isn't in sorted order with the hash
	#foreach my $key (keys (%{$xmld->{'script'}->{"$scriptName"}->{"designation"}})){


   $createdBy=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'createdBy'} ;
   $highlighter=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'highlighter'};
   $firstPL=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'firstPL'};
   $lastPL=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'lastPL'};
   $startT=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'start'};
   $stopT=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'stop'};
   $primaryId=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'primaryId'};
   
   
   
   $elapsedTime = $stopT - $startT;
   $Min = int($elapsedTime / 60);
   $Secs = ($elapsedTime) % 60;    
   $ElapsedStr = sprintf("%02d\:%02d", $Min, $Secs );
   
   $_=  $key;
   	#
   	# Key/name is in the form : "807:23 - 808:1 Anstice, David 2005-03-18"
   	# stip out the title
   	#
   s/.*\:.*? (.*)/$1/;
   
   	# DBM 2/21/09
   	# Strip off the _+suffix which was added to create unique designation names
   s/\_\+.*//;

   
   $desigTitle = $_;
   
   $firstPg = int($firstPL/100);
   $firstLn = $firstPL % 100;
   $endPg = int($lastPL/100);
   $endLn = $lastPL % 100;

   if ($reportFormat eq "Script-Excel") {
			#
			# Output the Header
			#
	   $oRng1 = "B" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");
	   $Range->{Value} = "$desigNb";
			#
			# Grab the Page line from 77:24 - 78:8
			#
	   $oRng1 = "C" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");
	   $Range->{Value} = "=" . $firstPg . "\&" . '":"' . "\&" . $firstLn . "";

	   $oRng1 = "D" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");
	   $Range->{Value} = "-";

	   $oRng1 = "E" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");
	   $Range->{Value} = "=" . $endPg . "\&" . '":"' . "\&" . $endLn . "";

	   $oRng1 = "F" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");
	   $Range->{Value} = "$desigTitle" ;
		#
		# Display the elapsed time
		#
	   $oRng1 = "G" . $lineNb;
	   $Range = $Sheet->Range("$oRng1");

	   $Range->{Value} = "$ElapsedStr" ;	    
   	   $lineNb++;	   
   } else {
   		
   		
   			#
   			# Check if there's a change in the Deponent or Date
   			# if so, then insert a section break and Modify the Page Header
   			#
   			
   		if ( length($lastPrimaryId)>0 && ($primaryId ne $lastPrimaryId) ) {
   				#
   				# Insert the Section Break
   				#
   			$MyWord->ActiveDocument->Tables($sectionNb)->Rows->Add ;
			$MyWord->ActiveDocument->Tables($sectionNb)->Rows($lineNb+1)->Select;	
   					
   			$MyWord->Selection->InsertBreak ({Type => wdSectionBreakNextPage});

			$myRange = $MyWord->ActiveDocument->Content;
			
			$NumColumns = 6;
			if ( $showComment ) {
				$NumColumns++;
			}
			if ( $splitResponse ) {
				$NumColumns++;
			}
			
			
			$MyWord->ActiveDocument->Tables->Add({ Range => $myRange,
				NumRows => 1, NumColumns => $NumColumns });

			$sectionNb++;

				#
				# Set the Font/Format for table
				#
			$MyWord->ActiveDocument->Tables($sectionNb)->Select;	
			$MyWord->Selection->Font->{Name} = 'Times New Roman' ;	
			$MyWord->Selection->Font->{Size} = 12 ;
			$MyWord->Selection->Font->{Bold} = 1 ;
			$MyWord->Selection->Font->{Underline} = 1 ;
			$MyWord->Selection->Font->{Align} = 2 ;
			$MyWord->Selection->Font->{Color} = RGB(0,0,0);
			
			$MyWord->ActiveDocument->Tables($sectionNb)->Columns(1)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
			$MyWord->ActiveDocument->Tables($sectionNb)->Columns(2)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 45 ));  #45;
			$MyWord->ActiveDocument->Tables($sectionNb)->Columns(3)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
			$MyWord->ActiveDocument->Tables($sectionNb)->Columns(4)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 45 ));  #45;
			$MyWord->ActiveDocument->Tables($sectionNb)->Columns(5)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
			if ( $showComment || $splitResponse ) {
			     if ( $showComment && $splitResponse ) {
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 100 ));  #90;
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 130 ));  #230;
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(8)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 100 ));  #230;
			     } elsif ( $showComment ) {
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 140 ));  #90;
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 190 ));  #230;
			     } else {
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 190 ));  #90;
				$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 140 ));  #230;

			     }
			} else {

			     $MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 320 ));  #320;
			}
			$MyWord->ActiveDocument->Tables($sectionNb)->Cell(1,1)->Select;

			$MyWord->Selection->TypeText ({Text => "Type"});
			$MyWord->Selection->MoveRight({Count => 1});
			$MyWord->Selection->TypeText ({Text => "Start Page"});
			$MyWord->Selection->MoveRight({Count => 1});
			$MyWord->Selection->TypeText ({Text => "Start Line"});
			$MyWord->Selection->MoveRight({Count => 1});
			$MyWord->Selection->TypeText ({Text => "End Page"});
			$MyWord->Selection->MoveRight({Count => 1});
			$MyWord->Selection->TypeText ({Text => "End Line"});
			$MyWord->Selection->MoveRight({Count => 1});
			if ( $showComment ) {
				$MyWord->Selection->TypeText ({Text => "$commentHeader"});
				$MyWord->Selection->MoveRight({Count => 1});			
			}
			$MyWord->Selection->TypeText ({Text => "Objections"});

			if ( $splitResponse ) {
				$MyWord->Selection->MoveRight({Count => 1});
				$MyWord->Selection->TypeText ({Text => "Responses"});

			}
				#
				# Lookup the deposition date
				# 1st, get the deponent name...
				#
			#$depoName = (keys (%{$xmld->{'deposition'}}))[0];
			$depoName = $mediaIdNameLookup{"$primaryId"};
			$depoDate = "xx/xx/xxxx";
			
			
			#if ( defined($xmld->{'deposition'}->{"$depoName"}->{"objections"}[0]) ) {
			#	$depoDate = $xmld->{'deposition'}->{"$depoName"}->{"date"};
			#} 
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->{LinkToPrevious} = 0;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->ParagraphFormat->{Alignment} = wdAlignParagraphCenter ;

			#$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Underline} = 1 ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->{Text} = "$longCaseName\n$title\n$depoName" ;

			$MyWord->ActiveDocument->Sections($sectionNb)->Footers(wdHeaderFooterPrimary)->Range->ParagraphFormat->{Alignment} = wdAlignParagraphCenter ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Footers(wdHeaderFooterPrimary)->PageNumbers->Add();


			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Name} = 'Times New Roman' ;	
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Size} = 12 ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Bold} = 1 ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Underline} = 0 ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Align} = 2 ;
			$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Color} = RGB(0,0,0);

   			
   			$lineNb = 1;
   		}
   		$lastPrimaryId = $primaryId;
   		$lineNb++;
   		
			#
			# Add the new row
			#
		$MyWord->ActiveDocument->Tables($sectionNb)->Rows->Add ;
		$MyWord->ActiveDocument->Tables($sectionNb)->Rows($lineNb)->Select;
		$MyWord->Selection->Font->{Underline} = 0 ;

			# Skip over the type field to the Starting Page
		$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,1)->Select;
		
		$party = $partys[$highlighter];
		$MyWord->Selection->TypeText ({Text => "$party"});
		$MyWord->Selection->MoveRight({Count => 1});
		$MyWord->Selection->TypeText ({Text => "$firstPg"});
		$MyWord->Selection->MoveRight({Count => 1});
		$MyWord->Selection->TypeText ({Text => "$firstLn"});	
		$MyWord->Selection->MoveRight({Count => 1});
		$MyWord->Selection->TypeText ({Text => "$endPg"});	
		$MyWord->Selection->MoveRight({Count => 1});
		$MyWord->Selection->TypeText ({Text => "$endLn"});	
		$MyWord->Selection->MoveRight({Count => 1});
		
			
		$depoName = $mediaIdNameLookup{"$primaryId"};

		
			#
			# Loop through the objections, looking for matches
			#		
		$foundObjection = 0; # none seen yet
		
		for ( $j=0; defined($xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]); $j++ ) {
			$case = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"case"};
			$caseID = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"caseID"};
			$objection = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"objection"};


			@sortedkeys = sort {($objection->{$a}->{'firstPL'}) <=> ($objection->{$b}->{'firstPL'})} keys %{$objection};

			foreach my $oookey ( @sortedkeys ) {

			#foreach my $oookey (keys (%{$objection})){	 

			    $ofirstPL = $objection->{$oookey}->{'firstPL'};
			    $viStartPage = int($ofirstPL/100);
			    $viStartLine = ($ofirstPL % 100);
			    $olastPL = $objection->{$oookey}->{'lastPL'};
			    $viEndPage = int($olastPL/100);
			    $viEndLine = ($olastPL % 100);
			    $byPlaintiff = lc($objection->{$oookey}->{'byPlaintiff'});
			    $state = $objection->{$oookey}->{'state'};
			    $objectionT = cleanExcelStrings($objection->{$oookey}->{'objection'});
			    $response = cleanExcelStrings($objection->{$oookey}->{'response'});
			    $response2 = cleanExcelStrings($objection->{$oookey}->{'response2'});
			    $response3 = cleanExcelStrings($objection->{$oookey}->{'response3'});
			    if ( length($response2) > 0 ) {
			    	$response = $response . "\;" . $response2;
			    }
			    if ( length($response3) > 0 ) {
			    	$response = $response . "\;" . $response3;
			    }
			    $ruling = cleanExcelStrings($objection->{$oookey}->{'ruling'});
			    $rulingText = cleanExcelStrings($objection->{$oookey}->{'rulingText'});
			    if ( length($rulingText) > 0 ) {
			    	$ruling = $ruling . "\;" . $rulingText;
			    }
			    $comment = cleanExcelStrings($objection->{$oookey}->{'comment'});

			    
			    if ( (($ofirstPL  >= $firstPL) && ( $ofirstPL <= $lastPL)) || 
			         (($olastPL  >= $firstPL) && ( $olastPL <= $lastPL))  ||
			         (($firstPL  >= $ofirstPL) && ( $firstPL <= $olastPL)) || 
			     	 (($lastPL  >= $ofirstPL) && ( $lastPL <= $olastPL))
			         ) 
			    {
					# send a hard enter if there was already an objection
				if ( $foundObjection ) {
					$lineNb++;

						#
						# Add the new row
						#
					$MyWord->ActiveDocument->Tables($sectionNb)->Rows->Add ;
					$MyWord->ActiveDocument->Tables($sectionNb)->Rows($lineNb)->Select;
					$MyWord->Selection->Font->{Underline} = 0 ;

						# Skip over the type field to the Starting Page
					$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,1)->Select;

					$party = $partys[$highlighter];
					$MyWord->Selection->TypeText ({Text => "$party"});
					$MyWord->Selection->MoveRight({Count => 1});
		
					$MyWord->Selection->TypeText ({Text => "$firstPg"});
					$MyWord->Selection->MoveRight({Count => 1});
					$MyWord->Selection->TypeText ({Text => "$firstLn"});	
					$MyWord->Selection->MoveRight({Count => 1});
					$MyWord->Selection->TypeText ({Text => "$endPg"});	
					$MyWord->Selection->MoveRight({Count => 1});
					$MyWord->Selection->TypeText ({Text => "$endLn"});	
					$MyWord->Selection->MoveRight({Count => 1});					
				}
							
				$OutStr = "Re: [" . $viStartPage . ":" . $viStartLine . "-" . $viEndPage . ":" . $viEndLine . "] " . chr(10) ;
				if ($byPlaintiff eq "yes" ) {
					$OutStr = $OutStr . "Pltf Obj ";
				} else {
					$OutStr = $OutStr . "Def Obj ";
				}
				$OutStr = $OutStr . "$objectionT";
				
				$objColumn = 6;
				if ( $showComment ) {
					$objColumn = 7;
					$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,6)->Range->InsertAfter( "$comment" );

				}
				
				$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn)->Range->InsertAfter( "$OutStr" );
					
				$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn)->Select;
				if ($byPlaintiff eq "yes") {
					$MyWord->Selection->Font->{Color} = RGBs("$pltfColor");
				} else {
					$MyWord->Selection->Font->{Color} = RGBs("$defColor");
				}
				
				if ( length($response) > 0 ) {
					#
					# Check responses.  If obj is plaintif, the response is defense
					#
				    my $responseOffset = 0;
				    if ($splitResponse) { 
				       $responseOffset = 1;	# put reponses in the nex column over
				    }
					
				    $OutStrR = "Re: [" . $viStartPage . ":" . $viStartLine . "-" . $viEndPage . ":" . $viEndLine . "] " . chr(10) ;
				    $lenOutStrR = length($OutStrR);
				    if ($byPlaintiff eq "yes") {	# so defense is the color of the response
					if ( ! $splitResponse) { 
					  $MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn+$responseOffset)->Range->InsertAfter( chr(10)  );
					}
					$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn+$responseOffset)->Range->InsertAfter( "$OutStrR"  . "Def Resp $response" );
					$rng3 = $MyWord->ActiveDocument->Range({Start => $MyWord->Selection->Start, End => $MyWord->Selection->Start + length($response) + $lenOutStrR + 11 });
					$rng3->Font->{Color} = RGBs("$defColor");

				    } else {
				    	if ( ! $splitResponse) { 
						$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn+$responseOffset)->Range->InsertAfter( chr(10)  );
					}
					$MyWord->ActiveDocument->Tables($sectionNb)->Cell($lineNb,$objColumn+$responseOffset)->Range->InsertAfter( "$OutStrR"  . "Pltf Resp $response" );
					$rng3 = $MyWord->ActiveDocument->Range({Start => $MyWord->Selection->Start, End => $MyWord->Selection->Start  + length($response) + $lenOutStrR + 11 });
					$rng3->Font->{Color} = RGBs("$pltfColor");	    
				    }
				}
								
				$foundObjection = 1;
			    }
			}
		}
		
   }
 
   if ($reportFormat eq "Script-Excel") { 
		#
		# Iterate through the transcript lines...
		#
	   for ( $i=0; defined $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'transcript'}[$i]; $i++ ) {
		#print "$i ";

		$PL = $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'transcript'}[$i]->{'pl'} ;
		$Pg = int($PL/100);
		$Ln = $PL % 100;
		$myText = $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'transcript'}[$i]->{'text'};

		$myQA = $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'transcript'}[$i]->{'qa'};
		if ( length($myQA)> 0 ) {
			$myText = "$myQA" . "\. $myText" ;
		}
		
		
		if ($reportFormat eq "Script-Excel") {  
				  #
				  # Output the page
				  #
			$oRng1 = "C" . $lineNb;
			$Range = $Sheet->Range("$oRng1");
			$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
			$Range->{Value} = "$Pg";

				#
				# Output the line
				#
			$oRng1 = "D" . $lineNb;
			$Range = $Sheet->Range("$oRng1");
			$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
			$Range->{Value} =  "$Ln";

				#
				# Output the Text
				#
			$oRng1 = "F" . $lineNb;
			$Range = $Sheet->Range("$oRng1");
			$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
			$Range->{Value} =  "$myText";
			#$depoName = (keys (%{$xmld->{'deposition'}}))[0];
		}

		#$keyName = (keys (%{$xmld->{'deposition'}}))[0];
			
		$depoName = $mediaIdNameLookup{"$primaryId"};
		
		#print "keyName=$keyName ;  depoName=$depoName\n";
		
			#for ( $k=0; defined((keys (%{$xmld->{'deposition'}}))[$k]) ; $k++ ) {
			#      $tempName = (keys (%{$xmld->{'deposition'}}))[$k] ;
	
		
		      # print "DepoName $k=$depoName\n";
		      # primaryId="Curfman_G_20051121"  



		for ( $j=0; defined($xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]); $j++ ) {
			$case = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"case"};
			$caseID = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"caseID"};
			$objection = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"objection"};

			foreach my $oookey (keys (%{$objection})){	 

			    $ofirstPL = $objection->{$oookey}->{'firstPL'};
			    $viStartPage = int($ofirstPL/100);
			    $viStartLine = ($ofirstPL % 100);
			    $olastPL = $objection->{$oookey}->{'lastPL'};
			    $viEndPage = int($olastPL/100);
			    $viEndLine = ($olastPL % 100);
			    $byPlaintiff = lc($objection->{$oookey}->{'byPlaintiff'});
			    $state = $objection->{$oookey}->{'state'};
			    $objectionT = cleanExcelStrings($objection->{$oookey}->{'objection'});
			    $response = cleanExcelStrings($objection->{$oookey}->{'response'});
			    $ruling = cleanExcelStrings($objection->{$oookey}->{'ruling'});
			    $comment = cleanExcelStrings($objection->{$oookey}->{'comment'});



				#
				# Check if we need to output the objection
				# $firstPL=designation start;  $lastPL=designation end
				#
			    $outputObj = 0;	
			    if ( ($firstPL == $PL) && 
			         ($ofirstPL < $firstPL ) &&
			         ($olastPL >= $firstPL ) &&
			         !defined($objectionsIdentified{"$oookey"})	#DBM 8/31/2010 only output once
			       ) {
			       
			       $outputObj = 1;
			       if ( $regSupressDup ) {
			           $objectionsIdentified{"$oookey"} = 1;
			       }
			    }
			    if ( ($Pg == $viStartPage) && ($Ln == $viStartLine) && !defined($objectionsIdentified{"$oookey"}) ) {
			    	$outputObj = 1;	
			    	if ( $regSupressDup ) {
			    	    $objectionsIdentified{"$oookey"} = 1;
			        }
			    }
			    

			    if ( $outputObj ) {
				$OutStr = "Re: [" . $viStartPage . ":" . $viStartLine . "-" . $viEndPage . ":" . $viEndLine . "] " . chr(10) ;


				if ($reportFormat eq "Script-Excel") {  
				    if ( $showObjection ) {
		#XXX print "Output Objection : $OutStr\n";

	
	
					if ($byPlaintiff eq "yes") {
						$oRng1 = "H" . $lineNb;
						$Range = $Sheet->Range("$oRng1");
						$Range->Font->{Color} = RGBs("$pltfColor");

		#XXX		print "Existing : $Range->{Value}\n";	

						if ( length($Range->{Value}) > 1 ) {
						    	$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Pltf Obj $objectionT";
						} else {
							$Range->{Value} =  $OutStr . "Pltf Obj $objectionT";
						}
										
					} else {

						$oRng1 = "H" . $lineNb;
						$Range = $Sheet->Range("$oRng1");
						$Range->Font->{Color} = RGBs("$defColor");
		#XXX		print "Existing : $Range->{Value}\n";	
						
						if ( length($Range->{Value}) > 1 ) {
							$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Def Obj $objectionT";
						} else {
							$Range->{Value} =  $OutStr . "Def Obj $objectionT";
						
						}
									

					}
					if ( length($response) > 0 ) {
							#
							# Check responses.  If obj is plaintif, the response is defense
							#
						  if ($byPlaintiff eq "yes") {	# so defense
							if (($splitResponse)) {
								$oRng1 = "I" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$defColor");;
								$Range->{Value} =  $OutStr . "Def Resp $response";						
							} else {
								$oRng1 = "H" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$defColor");;
								$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Def Resp $response";					
							}
							$OutStr = $OutStr . "Def Resp ";
						  } else {
							if (($splitResponse)) {
								$oRng1 = "I" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$pltfColor");;
								$Range->{Value} =  $OutStr  . "Pltf Resp $response";						

							} else {
								$oRng1 = "H" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$pltfColor");;
								$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Pltf Resp $response";					

							}												  
						  }		
						    
					}
						# set the colors and bolding
					@myrange= ( "H", "I" );
					excelFormatObjResp($lineNb, @myrange);
					
					$oRng1 = "H" . $lineNb;
					$Range = $Sheet->Range("$oRng1");
					if ( length($Range->{Value}) > 1 ) {
							#
							# Update the pointer to the lines with text
							#
						$LinesWithTextArr[$lc] = $lineNb;
						$lc++;
					}
					
					if ( $showRuling && (length($ruling) > 0) ) {
						$oRng1 = chr(71 + $RulingColumn+1) . $lineNb;
						$Range  = $Sheet->Range($oRng1);
						$Range->{Value} = $ruling;
					}					
					
				   }  # if $showObjection
				   else {
					if ( $showRuling && (length($ruling) > 0) ) {
						$oRng1 = chr(71 + $RulingColumn+1) . $lineNb;
						$Range  = $Sheet->Range($oRng1);
						$Range->{Value} = $ruling;
					}						   
				   	$LinesWithTextArr[$lc] = $lineNb;
					$lc++;
				   }
					
					
				}  # if excel
			    }  # if pg=pg line=line

			}  # foreach my $oookey
		}
		if ($reportFormat eq "Script-Excel") { 
			$lineNb++;
		}
	   }  #  for ( $j=0; defined($xmld->{'

	   if ($reportFormat eq "Script-Excel") {
		$lineNb++; 
	   }
	   $desigNb++;
	}  #  for ( $i=0; defined $xmld->{'scrip   -- transcript lines
}  # if Excel

if ($reportFormat eq "Designation-Word") {
	$MyWord->ActiveDocument->Tables(1)->Select;	
	foreach $i ( -1,-2,-3,-4,-5,-6 ) {
		$MyWord->ActiveDocument->Tables(1)->Borders($i)->{LineStyle} = $xlContinuous;
		$MyWord->ActiveDocument->Tables(1)->Borders($i)->{Weight} = $xlThick;
	}		
	$MyWord->ActiveDocument->SaveAs($saveAsName);
      	$MyWord->ActiveDocument->Close(); 
      	$MyWord->Quit;	# quit the word application as well

   	WriteProgress(100);	
   
	exit (0);
}

$ExcelLastLineNb = $lineNb;



  #
  # Loop through the lines that have objections, set the line height to fit.
  #
  
for ( $j=0; $j<$lc; $j++ ) {

  if ( ($lc > 0) && (($j % 5)==0) ) {
   $donePercent = 50 +  ( (48*$j)/$lc );
   WriteProgress($donePercent);	
  } 	
   	
   	
	$lineNb = $LinesWithTextArr[$j] ;
  
  $oRng1 = "H" . $lineNb;
  
	$Range = $Sheet->Range($oRng1);	
	$origRowHeight = ($Range->{RowHeight});
	$lineHgt = int(($origRowHeight / 12.75) + 0.5); # the number of lines
	#
	# Check the position of the next objection.  That is a limit
	# unless this is the last objection
	#
	if ($j < ($lc-1) )  {
		$nbToMerge = $LinesWithTextArr[$j + 1] - $lineNb - 2;
	} else {
		$nbToMerge = $lineHgt-1;	# was $lineNb - 1;
	}
	$nbTospread = $lineHgt - $nbToMerge;
	if ($nbToMerge > $lineHgt)  {
		$nbToMerge = $lineHgt - 1;
	}
	if ($nbToMerge > 0)  {
		$oRng1 = "H" . $lineNb . "\:H" . int($lineNb + $nbToMerge);
		$Range = $Sheet->Range($oRng1);		
		$Range->{MergeCells} = 1;
				#
				# Spread all three lines
				#
		#if (($splitResponse))  {
			$oRng2 = "I" . $lineNb . "\:I" . int($lineNb + $nbToMerge);
			$Range2 = $Sheet->Range($oRng2);		
			$Range2->{MergeCells} = 1;
				#
			$oRng2 = "J" . $lineNb . "\:J" . int($lineNb + $nbToMerge);
			$Range2 = $Sheet->Range($oRng2);		
			$Range2->{MergeCells} = 1;
			
		#}
		    #
		    # Spread the rest of the lines
		    #
		if ($nbTospread > 1)  {
			if ($j < ($lc-1) )  {
				$lineToSpread = $LinesWithTextArr[$j + 1] - 2;
			} else {
				$lineToSpread = $lineNb;	
			}		
		
		
		
		
			$oRng1 = "H" . $lineToSpread ;
			$Range = $Sheet->Range($oRng1);		
			$Range->{RowHeight} = ($nbTospread * 12.75);
		}
	} 	  		
} 
  
   #
   # Line number in column A
   #
$oRng1 = "A1:A" . $lineNb;
$Range = $Sheet->Range($oRng1);
$Range->Cells(1, 1)->{Value} = "1";
$Range->DataSeries( {Rowcol => $xlColumns, Type => xlLinear, Step => 1 } );

$Sheet->Columns("A:A")->EntireColumn->{Hidden} = True;
$Sheet->Columns("B:B")->EntireColumn->{Hidden} = True;

$oRng1 = "B1:" . chr(71+ $extraColumns+ $ColumnCount ) .  $ExcelLastLineNb;
$Sheet->PageSetup->{PrintArea} = "$oRng1";

$Book->SaveAs($saveAsName);
$Book->Close;
$Excel->Quit;

exit(0);


sub printWordHeader()
{

	#
	# Open Existing Word? 
	#
	$MyWord = Win32::OLE->new('Word.Application') or die "Cannot create Word.Application";
	$MyWord->{Visible} = $visible;

	# $MyWord->Documents->Open($file) || die("Unable to open $file ", Win32::OLE->LastError());
	$doc = $MyWord->Documents->Add  or die "Can't create new Word document: $!\n";
	
	$myRange = $MyWord->ActiveDocument->Content;
	
	my $page = $doc->{'PageSetup'};
        $page->{LeftMargin} = ($leftMargin * 72);	#$Excel->InchesToPoints("$leftMargin");
        $page->{RightMargin} = ($rightMargin * 72);	#$Excel->InchesToPoints("$rightMargin");
        $page->{TopMargin} = ($topMargin * 72);		#$Excel->InchesToPoints("$topMargin");
        $page->{BottomMargin} = ($bottomMargin * 72);	# $Excel->InchesToPoints("$bottomMargin");	
	
	$NumColumns = 6;
	if ( $showComment ) {
		$NumColumns++;
	}
	if ( $splitResponse ) {
		$NumColumns++;
	}
			
	$MyWord->ActiveDocument->Tables->Add({ Range => $myRange,
		NumRows => 1, NumColumns => $NumColumns });
		
	$sectionNb = 1;
	
		#
		# Set the Font/Format for table
		#
	$MyWord->ActiveDocument->Tables($sectionNb)->Select;
	
	$MyWord->ActiveDocument->Tables($sectionNb)->Borders->{InsideLineStyle} = wdLineStyleSingle;
	$MyWord->ActiveDocument->Tables($sectionNb)->Borders->{OutsideLineStyle} = wdLineStyleSingle;
	
	$MyWord->Selection->Font->{Name} = 'Times New Roman' ;	
	$MyWord->Selection->Font->{Size} = 12 ;
	$MyWord->Selection->Font->{Bold} = 1 ;
	$MyWord->Selection->Font->{Underline} = 1 ;
	$MyWord->Selection->Font->{Align} = 2 ;
	$MyWord->Selection->Font->{Color} = RGB(0,0,0);
	
	
	
	$MyWord->ActiveDocument->Tables($sectionNb)->Columns(1)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
 	$MyWord->ActiveDocument->Tables($sectionNb)->Columns(2)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 45 ));  #45;
 	$MyWord->ActiveDocument->Tables($sectionNb)->Columns(3)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
 	$MyWord->ActiveDocument->Tables($sectionNb)->Columns(4)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 45 ));  #45;
 	$MyWord->ActiveDocument->Tables($sectionNb)->Columns(5)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 40 ));  #40;
	if ( $showComment || $splitResponse ) {
	     if ( $showComment && $splitResponse ) {
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 100 ));  #90;
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 130 ));  #230;
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(8)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 100 ));  #230;
	     } elsif ( $showComment ) {
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 140 ));  #90;
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 190 ));  #230;
	     } else {
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 190 ));  #90;
		$MyWord->ActiveDocument->Tables($sectionNb)->Columns(7)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 140 ));  #230;

	     }
	     

	} else {

	     $MyWord->ActiveDocument->Tables($sectionNb)->Columns(6)->{Width} = (getConfigParam( $xmlc, "columnWidthA", 320 ));  #320;
	}
 
	$MyWord->ActiveDocument->Tables($sectionNb)->Cell(1,1)->Select;
	
	$MyWord->Selection->TypeText ({Text => "Type"});
	$MyWord->Selection->MoveRight({Count => 1});
	$MyWord->Selection->TypeText ({Text => "Start Page"});
	$MyWord->Selection->MoveRight({Count => 1});
	$MyWord->Selection->TypeText ({Text => "Start Line"});
	$MyWord->Selection->MoveRight({Count => 1});
	$MyWord->Selection->TypeText ({Text => "End Page"});
	$MyWord->Selection->MoveRight({Count => 1});
	$MyWord->Selection->TypeText ({Text => "End Line"});
	$MyWord->Selection->MoveRight({Count => 1});

	if ( $showComment ) {
		$MyWord->Selection->TypeText ({Text => "$commentHeader"});
		$MyWord->Selection->MoveRight({Count => 1});

	}	
	
	$MyWord->Selection->TypeText ({Text => "Objections"});
	
	
	if ( $splitResponse ) {
		$MyWord->Selection->MoveRight({Count => 1});
		$MyWord->Selection->TypeText ({Text => "Responses"});
		
	}

		#
		# Lookup the deposition date
		# 1st, get the deponent name...
		#
	$depoName = (keys (%{$xmld->{'deposition'}}))[0];
	#$depoDate = "xx/xx/xxxx";
	#if ( defined($xmld->{'deposition'}->{"$depoName"}->{"objections"}[0]) ) {
	#$depoDate = $xmld->{'deposition'}->{"$depoName"}->{"date"};
	#} 
	
	
	
	
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->ParagraphFormat->{Alignment} = wdAlignParagraphCenter ;

	#$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Underline} = 1 ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->{Text} = "$longCaseName\n$title\n$depoName" ;
	
	$MyWord->ActiveDocument->Sections($sectionNb)->Footers(wdHeaderFooterPrimary)->Range->ParagraphFormat->{Alignment} = wdAlignParagraphCenter ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Footers(wdHeaderFooterPrimary)->PageNumbers->Add();
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Name} = 'Times New Roman' ;	
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Size} = 12 ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Bold} = 1 ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Underline} = 0 ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Align} = 2 ;
	$MyWord->ActiveDocument->Sections($sectionNb)->Headers(wdHeaderFooterPrimary)->Range->Font->{Color} = RGB(0,0,0);

}



sub printExcelHeader()
{
    if ( $reportFormat eq "Transcript-Excel") {
	$extraColumns = 6;
    } else {
    	$extraColumns = 0;
    
    }


	#
	# Open Existing Excel 
	#
    $Excel = Win32::OLE->new('Excel.Application');	# Win32::OLE->GetActiveObject('Excel.Application') ||
    $Excel->{'Visible'} = $visible;		#0 is hidden, 1 is visible
    $Excel->{DisplayAlerts}=1;	#0 is hide alerts

    $Excel->{SheetsInNewWorkbook} = 1;
    $Book = $Excel->Workbooks->Add;
    $Sheet = $Book->Worksheets(1);
    $Sheet->{Name} = 'Objections';

	#
	# Misc Excel Page Setup
	#

    $Sheet->Range("A7:J7")->Select ;
    $Excel->ActiveWindow->FreezePanes(1);
        #
        # Set Page Margins, title, and footer
        #
    
    $Sheet->PageSetup->{LeftMargin} = ($leftMargin * 72);	#$Excel->InchesToPoints("$leftMargin");
    $Sheet->PageSetup->{RightMargin} = ($rightMargin * 72);	#$Excel->InchesToPoints("$rightMargin");
    $Sheet->PageSetup->{TopMargin} = ($topMargin * 72);		#$Excel->InchesToPoints("$topMargin");
    $Sheet->PageSetup->{BottomMargin} = ($bottomMargin * 72);	# $Excel->InchesToPoints("$bottomMargin");
    $Sheet->PageSetup->{HeaderMargin} = ($headerMargin * 72);		#$Excel->InchesToPoints("0.25");
    $Sheet->PageSetup->{FooterMargin} = ($footerMargin * 72);		#$Excel->InchesToPoints("0.25");
    $Sheet->PageSetup->{Zoom} = ($zoom);
        

            #
            # Set the Page Footer
            # and the rows to repeat at the top
            #

    $Sheet->PageSetup->{PrintTitleRows} = '$5:$6';

    if ( $reportFormat eq "Script-Excel" ) {
	    $Sheet->PageSetup->{CenterFooter} = "&P";

	      #$mystr = '11/12/99 10:30AM';   
	    my ($sec,$min,$hour,$mday,$mon,$year,$wday,$yday,$isdst) = localtime();
	    $mystr = sprintf("%02.2d/%02.2d/%02.2d %02.2d\:%02.2d", $mon+1,$mday,($year+1900)%100,$hour,$min );
	    $Sheet->PageSetup->{RightFooter} = "$mystr";     # 11/12/06 10:30AM
    }
    
    if ( $reportFormat eq "Transcript-Excel") {

	    $Sheet->Columns("A:A")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthA", 5 ));
	    $Sheet->Columns("B:B")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthB", .5 ));
	    $Sheet->Columns("C:C")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthC", .5 ));
	    $Sheet->Columns("D:D")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthD", .5 ));
	    $Sheet->Columns("E:E")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthE", .5 ));
	    $Sheet->Columns("F:F")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthF", .5 ));
	    $Sheet->Columns("G:G")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthG", .5 ));
	    $Sheet->Columns("H:H")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthH", .5 ));
	    
	    $Sheet->Columns("I:I")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthI", 5.43 ));
	    $Sheet->Columns("J:J")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthJ",2));
	    $Sheet->Columns("K:K")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthK",.5));
	    $Sheet->Columns("L:L")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthL",47));
	    $Sheet->Columns("M:M")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthM",.5));
	    $Sheet->Columns("N:N")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthN",20));
	    $Sheet->Columns("O:O")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthO",18));
	    $Sheet->Columns("P:P")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthP",18));
	    $Sheet->Columns("Q:Q")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthQ",18));
	    $Sheet->Columns("R:R")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthR",18));
	    
    } else {

	    $Sheet->Columns("A:A")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthA", 5 ));
	    $Sheet->Columns("B:B")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthB", 3 ));
	    $Sheet->Columns("C:C")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthC", 5.43 ));
	    $Sheet->Columns("D:D")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthD",2));
	    $Sheet->Columns("E:E")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthE",5.43));
		    $Sheet->Columns("G:G")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthG",5));
	     	
	    if ( $showObjection && ($splitResponse || $showRuling) ) {
	        $Sheet->Columns("F:F")->{ColumnWidth}= 44;
	    	$Sheet -> Range("F:F") -> Font -> {Size}       = 10.5;
	    	$Sheet->Columns("H:H")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthH",20));
		    
	    	$Sheet->Columns("I:I")->{ColumnWidth}= 17;
	    } else {
	        $Sheet->Columns("F:F")->{ColumnWidth}=(getConfigParam( $xmlc, "columnWidthF",47));

		    $Sheet->Columns("H:H")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthH",20));
		    $Sheet->Columns("I:I")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthI",18));
	    }
	    $Sheet->Columns("J:J")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthJ",18));
	    $Sheet->Columns("K:K")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthK",18));
	    $Sheet->Columns("L:L")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthL",18));
	    $Sheet->Columns("M:M")->{ColumnWidth}= (getConfigParam( $xmlc, "columnWidthM",18));




    }


    $oRng1 = $Sheet->Range("B:I");
    $oRng1->Borders($xlInsideHorizontal)->{LineStyle} = $xlnone;
    $oRng1->Borders($xlInsideVertical)->{LineStyle} = $xlnone;
 
   # $oRng1 = $Sheet->Range("A:A");
   # $oRng1->Borders(xlEdgeRight)->{LineStyle} = $xlContinuous;
   # $oRng1->Borders(xlEdgeRight)->{ColorIndex} = 5; # Dark Blue
   # $oRng1->Borders(xlEdgeRight)->{Weight} = $xlMedium;
   # $oRng1->Interior->{ColorIndex} = 15;
  
    
    
    $ColumnCount = 0;
    if ($showObjection) 
    {
    	if ( $splitResponse ) {
    		$RulingColumn = 2;
    	}
    	else {
    		$RulingColumn = 1;
    	}
    	
        $ColumnCount = $ColumnCount + 1;
        $oCell = chr(71+ $extraColumns+ $ColumnCount ) .  "5";
       
       
        $oRng1 = $Sheet->Range($oCell);
        $oRng1->Font->{Bold} = True;
        $oRng1->{HorizontalAlignment} = $xlHAlignCenter;
        if ($splitResponse) {
            $oRng1->{Value} = "Objections";
        } else {
            $oRng1->{Value} = "Objections";  
            $oRng1->{RowHeight} = 12.75;
        }
        $oCell = chr(71+ $extraColumns + $ColumnCount) . "6";

 
        $oRng1 = $Sheet->Range($oCell);
        $oRng1->Font->{Bold} = 1;
        $oRng1->{HorizontalAlignment} = $xlHAlignCenter;
            #
            # Also set the Top orientation
            #
        $oRng1->{VerticalAlignment} = $xlTop;
        $oRng1->{Value} = "In " . $shortCaseName;
    } else {
    	# if no objection then no split reponse
    	$splitResponse = 0;
    	$RulingColumn = 0;
    }
    
    if ($splitResponse) {
    	$ColumnCount = $ColumnCount + 1;
    }
    
    
    if ($showRuling) {
	$ColumnCount = $ColumnCount + 1;

	$oCell = chr(71+ $extraColumns + $RulingColumn+1) . "5";
	$oRng1 = $Sheet->Range($oCell);
	$oRng1->Font->{Bold} = 1;
	$oRng1->{HorizontalAlignment} = $xlHAlignCenter;
	
	    #
	    # Also set the Top orientation
	    #
	$oRng1->{VerticalAlignment} = xlTop;
	$oRng1->{Value} = "Rulings";
 

   }
    
   if ($splitResponse) {
	$oCell = chr(71+ $extraColumns + $RulingColumn) . "5";
	$oRng1 = $Sheet->Range($oCell);
	$oRng1->Font->{Bold} = 1;
	$oRng1->{HorizontalAlignment} = $xlHAlignCenter;
	
	    #
	    # Also set the Top orientation
	    #
	$oRng1->{VerticalAlignment} = xlTop;
	$oRng1->{Value} = "Responses In";
 

	$oCell = chr(71+ $extraColumns + $RulingColumn) . "6";
	$oRng1 = $Sheet->Range($oCell);
	$oRng1->Font->{Bold} = 1;
	$oRng1->{HorizontalAlignment} = $xlHAlignCenter;
	$oRng1->{Value} = $shortCaseName;

   }
   	#
   	# Set the vertical alignment to top for all columns
   	#
    $oCell = "A:Q";
    $oRng1 = $Sheet->Range($oCell);
    $oRng1->{VerticalAlignment} = xlTop;
   
#  print "ColumnCount=$ColumnCount\n";
 
    if ( $ColumnCount > 2 ) {
    	$zoom = 80;
    	$Sheet->PageSetup->{Zoom} = ($zoom);
    }
 
 
 
        #
        # Markup the last column
        #
    $oCell = chr(71+ $extraColumns + $ColumnCount) . ":" . chr(71+ $extraColumns + $ColumnCount);
     
    $oRng1 = $Sheet->Range($oCell);
    $oRng1->{VerticalAlignment} = $xlTop;
    
    $oCell = "B1\:" . chr(71+ $extraColumns + $ColumnCount) . "1";
    $oRng1 = $Sheet->Range($oCell);
    $oRng1->Font->{Bold} = 1;
    $oRng1->{HorizontalAlignment} = 3;	# was $xlHAlignCenter;
    $oRng1->{MergeCells} = 1;
    
    $oRng1->{Value} =  "$longCaseName";
    
    $oCell = "B2:" . chr(71+ $extraColumns + $ColumnCount) . "2";
    $oRng1 = $Sheet->Range($oCell);
    $oRng1->Font->{Bold} = 1;
    $oRng1->{HorizontalAlignment} = 3;
    $oRng1->{MergeCells} = 1;
    
    $oRng1->{Value} = "Deposition Designations for $selectedDeponent" ;  # was & Left(mystr, iPos)    ;
  
    if ( $reportFormat eq "Script-Excel") {
		#
		# Columns on Fields
		#
	    $oRng1 = $Sheet->Range("H:H");
	    $oRng1->Borders(xlEdgeLeft)->{LineStyle} = $xlContinuous;
	    $oRng1->Borders(xlEdgeLeft)->{Weight} = $xlThin;
	    $oRng1->Borders(xlEdgeRight)->{LineStyle} = $xlContinuous;
	    $oRng1->Borders(xlEdgeRight)->{Weight} = $xlThin;
	    $oRng1->{VerticalAlignment} = $xlTop;
    }
	#
	# DBM, force wrap text, then resize
	#
    $oRng1->{WrapText} = 1;
  
        #
        # Clear the cells to the Right
        # DBM 12/14/09 Hide them, not clear them
    $oCell = chr(72 + $extraColumns+ $ColumnCount) . ":T";
    $oRng1 = $Sheet->Range($oCell);
    #$oRng1->Interior->{ColorIndex} = 15;
    $oRng1->Range($oCell)->EntireColumn->{Hidden} = True;

}


sub doTranscriptExcel {
  $maxLnNb = 0; # DBM 2/4/08 track the last line of transcript for PrintArea command
  $lastPrimaryId = "";
  $sectionNb = 1;
    
  $nbPages = 0;
  	#
  	# Get the number of pages, use to track percentage complete
  	#
  
  for ( $nm=0; $nm<$nbMediaIDs; $nm++ ) {
    $depoName = $nameArr[$nm];    
    $linesPerPage = $xmld->{'deposition'}->{"$depoName"}->{"linesPerPage"};
    for ( $seg=1; defined($xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}); $seg++ ) {
    	$firstPL = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'firstPL'};
    	$lastPL = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'lastPL'};
  	$nbPages = $nbPages + ( $lastPL/100 - $firstPL/100 );
    }
  }	
  
  
  if ( $nbPages < 1 ) { $nbPages=1; }
#  print "Number of Pages=$nbPages\n";
  $pagesOutput = 0;	
  
  
  for ( $nm=0; $nm<$nbMediaIDs; $nm++ ) {
      #print "MediaID=" . $nameArr[$nm] . "\n";
    $depoName = $nameArr[$nm];
    
    $linesPerPage = $xmld->{'deposition'}->{"$depoName"}->{"linesPerPage"};
    
      #print "linesPerPage=$linesPerPage\n";
    
    for ( $seg=1; defined($xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}); $seg++ ) {
    
        for ( $ln=0; defined($xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]); $ln++ ) {
    
		$PL = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]->{'pl'};
		$Pg = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]->{'page'};
		$Ln = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]->{'line'};
		$myText = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]->{'text'};
		$myQA = $xmld->{'deposition'}->{"$depoName"}->{"segment"}->{"$seg"}->{'transcript'}[$ln]->{'qa'};

		if ( length($myQA)> 0 ) {
			$myText = "$myQA" . "\. $myText" ;
		}
			  #
			  # Output the page
			  #
		if ( $Ln eq "1" ) {
			$pagesOutput = $pagesOutput + 1;			  
			$donePercent = 4 +  ( (76*$pagesOutput)/$nbPages );
			WriteProgress($donePercent);	
			 	
				#
				# insert a page break
				#
			if ( $lineNb > 12 ) {
				$oRng1 = "A" . $lineNb . ":A" . $lineNb;
				$Range = $Sheet->Range("$oRng1");
				$Range->Cells(1, 1)->{PageBreak} = xlManual;
			}
			$oRng1 = "I" . $lineNb;
			$Range = $Sheet->Range("$oRng1");
			#$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
			$Range->{Value} = "$Pg";
		}

			#
			# Output the line
			#
		$oRng1 = "J" . $lineNb;
		$Range = $Sheet->Range("$oRng1");
		#$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
		$Range->{Value} =  "$Ln";

			#
			# Output the Text
			#
		$oRng1 = "L" . $lineNb;
		$Range = $Sheet->Range("$oRng1");
		#$Range->Font->{Color} = RGBs($DesigColors[int($highlighter)]);
		$Range->{Value} =  "$myText";
		
		if ( $lineNb > $maxLnNb ) {
			$maxLnNb = $lineNb ;
		}
		
			#
			# Loop on all Designations
			#

		foreach $key (@keyarray) {
		   $highlighter=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'highlighter'};
		   $firstPL=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'firstPL'};
		   $lastPL=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'lastPL'};
		   $startT=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'start'};
		   $stopT=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'stop'};
		   $primaryId=  $xmld->{'script'}->{"$scriptName"}->{"designation"}->{$key}->{'primaryId'};

		   $firstPg = int($firstPL/100);
		   $firstLn = $firstPL % 100;
		   $endPg = int($lastPL/100);
		   $endLn = $lastPL % 100;
		   
		   	#
		   	# Is the curr line within the Designation
		   	#
			#print "$depoName eq " . $mediaIdNameLookup{"$primaryId"} . "\n";
		   if ( ($depoName eq $mediaIdNameLookup{"$primaryId"} ) && ($firstPL <= $PL) && ($lastPL >= $PL) ) {
		   	$nextLn = $lineNb+1;
		   	$oRng1 = chr(65+$highlighter) . $lineNb . ":" . chr(65+$highlighter) . $nextLn ;
				#print "oRng1=$oRng1\n";
			$Range = $Sheet->Range("$oRng1");
			$Range->Interior->{Color} = RGBs($DesigColors[int($highlighter)]);

#############################################################
#			if ( 1 ) {
			for ( $j=0; defined($xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]); $j++ ) {
					$case = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"case"};
					$caseID = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"caseID"};
					$objection = $xmld->{'deposition'}->{"$depoName"}->{"objections"}[$j]->{"objection"};

		
					foreach my $oookey (keys (%{$objection})){
		

					    $ofirstPL = $objection->{$oookey}->{'firstPL'};
					    $viStartPage = int($ofirstPL/100);
					    $viStartLine = ($ofirstPL % 100);
					    $olastPL = $objection->{$oookey}->{'lastPL'};
					    $viEndPage = int($olastPL/100);
					    $viEndLine = ($olastPL % 100);
					    $byPlaintiff = lc($objection->{$oookey}->{'byPlaintiff'});
					    $state = $objection->{$oookey}->{'state'};
					    $objectionT = cleanExcelStrings($objection->{$oookey}->{'objection'});
					    $response = cleanExcelStrings($objection->{$oookey}->{'response'});
					    $ruling = cleanExcelStrings($objection->{$oookey}->{'ruling'});
					    $comment = cleanExcelStrings($objection->{$oookey}->{'comment'});
		

						#
						# Check if we need to output the objection
						# $firstPL=designation start;  $lastPL=designation end
						#
					    $outputObj = 0;	
					    if ( ($firstPL == $PL) && 
						 ($ofirstPL < $firstPL ) &&
						 ($olastPL >= $firstPL )
					       ) {

					       $outputObj = 1;
					
					    }
					    if ( ($Pg == $viStartPage) && ($Ln == $viStartLine) ) {
						$outputObj = 1;	
					
					    }


					    if ( $outputObj ) {
						    $OutStr = "Re: [" . $viStartPage . ":" . $viStartLine . "-" . $viEndPage . ":" . $viEndLine . "] " . chr(10) ;

		#XXX		print "Output Objection : $OutStr\n";

						    if ( $showObjection ) {

								#
								# Check for existing string
								#


							if ($byPlaintiff eq "yes") {
								$oRng1 = "N" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$pltfColor");
									
		#XXX		print "Existing : $Range->{Value}\n";	
								
								if ( length($Range->{Value}) > 1 ) {
									$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Pltf Obj $objectionT";
								} else {
									$Range->{Value} =  $OutStr . "Pltf Obj $objectionT";
								}								
								
								
							} else {

								$oRng1 = "N" . $lineNb;
								$Range = $Sheet->Range("$oRng1");
								$Range->Font->{Color} = RGBs("$defColor");;
								#$Range->{Value} =  $OutStr . "Def Obj $objectionT";	
								
		#XXX		print "Existing : $Range->{Value}\n";	
								if ( length($Range->{Value}) > 1 ) {
									$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Def Obj $objectionT";
								} else {
									$Range->{Value} =  $OutStr . "Def Obj $objectionT";
								}	

							}
							if ( length($response) > 0 ) {
									#
									# Check responses.  If obj is plaintif, the response is defense
									#
								  if ($byPlaintiff eq "yes") {	# so defense
									if (($splitResponse)) {
										$oRng1 = "O" . $lineNb;
										$Range = $Sheet->Range("$oRng1");
										$Range->Font->{Color} = RGBs("$defColor");;
										$Range->{Value} =  $OutStr . "Def Resp $response";						
									} else {
										$oRng1 = "N" . $lineNb;
										$Range = $Sheet->Range("$oRng1");
										$Range->Font->{Color} = RGBs("$defColor");;
										$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Def Resp $response";					
									}
									$OutStr = $OutStr . "Def Resp ";
								  } else {
									if (($splitResponse)) {
										$oRng1 = "O" . $lineNb;
										$Range = $Sheet->Range("$oRng1");
										$Range->Font->{Color} = RGBs("$pltfColor");;
										$Range->{Value} =  $OutStr  . "Pltf Resp $response";						

									} else {
										$oRng1 = "N" . $lineNb;
										$Range = $Sheet->Range("$oRng1");
										$Range->Font->{Color} = RGBs("$pltfColor");;
										$Range->{Value} =  $Range->{Value} . chr(10) . $OutStr . "Pltf Resp $response";					

									}												  
								  }		

							}
								#
							@myrange= ( "N", "O" );
							excelFormatObjResp($lineNb);

							$oRng1 = "N" . $lineNb;
							$Range = $Sheet->Range("$oRng1");
							if ( length($Range->{Value}) > 1 ) {
									#
									# Update the pointer to the lines with text
									#
								$LinesWithTextArr[$lc] = $lineNb;
								$lc++;
							}

							if ( $showRuling && (length($ruling) > 0) ) {
								$oRng1 = chr(71+ $extraColumns + $RulingColumn+1) . $lineNb;
								$Range  = $Sheet->Range($oRng1);
								$Range->{Value} = $ruling;
							}					

						   }  # if $showObjection
						   else {
							if ( $showRuling && (length($ruling) > 0) ) {
								$oRng1 = chr(71+ $extraColumns + $RulingColumn+1) . $lineNb;
								$Range  = $Sheet->Range($oRng1);
								$Range->{Value} = $ruling;
							}						   
							$LinesWithTextArr[$lc] = $lineNb;
							$lc++;
						   }



					    }  # if OutputObjection

					}  # foreach my $oookey
				

				# $lineNb++;

			   }  #  for ( $j=0; defined($xmld->{'


#			} # if (1 )
#############################################################
		   }
		   
		   
		}


		
		
		$lineNb += 2;
	}
    }
  }
  
  
	  #
	  # Loop through the lines that have objections, set the merge and set the font size to fit.
	  #

	for ( $j=0; $j<$lc; $j++ ) {
	
		if ( ($lc > 0) && (($j % 5)==0) ) {
		   $donePercent = 81 +  ( (18*$j)/$lc );
		   WriteProgress($donePercent);	
		} 		
	
	
	
		$lineNb = $LinesWithTextArr[$j] ;

	  	$oRng1 = "N" . $lineNb;

		$Range = $Sheet->Range($oRng1);	
		$origRowHeight = ($Range->{RowHeight});
		$lineHgt = int(($origRowHeight / 12.75) + 0.5); # the number of lines
		#
		# Check the position of the next objection.  That is a limit
		# unless this is the last objection
		#
		if ($j < ($lc-1) )  {
			$nbToMerge = $LinesWithTextArr[$j + 1] - $lineNb - 2;
		} else {
			$nbToMerge = $lineHgt-1;	# was $lineNb - 1;
		}
		$nbTospread = $lineHgt - $nbToMerge;
		if ($nbToMerge > $lineHgt)  {
			$nbToMerge = $lineHgt - 1;
		}
		if ($nbToMerge > 0)  {
			$oRng1 = "N" . $lineNb . "\:N" . int($lineNb + $nbToMerge);
			$Range = $Sheet->Range($oRng1);		
			$Range->{MergeCells} = 1;
				#
				# Spread all three lines
				#
			$oRng2 = "O" . $lineNb . "\:O" . int($lineNb + $nbToMerge);
			$Range2 = $Sheet->Range($oRng2);		
			$Range2->{MergeCells} = 1;
				#
			$oRng2 = "P" . $lineNb . "\:P" . int($lineNb + $nbToMerge);
			$Range2 = $Sheet->Range($oRng2);		
			$Range2->{MergeCells} = 1;

			    #
			    # Spread the rest of the lines
			    #
			if ($nbTospread > 1)  {
				$oRng1 = "N" . $lineNb . "\:N" . int($lineNb + $nbToMerge);
				$Range = $Sheet->Range($oRng1);		
				$Range->Font->{Size} = 8;
				
					#
					# Spread all three lines
					#
				$oRng2 = "O" . $lineNb . "\:O" . int($lineNb + $nbToMerge);
				$Range2 = $Sheet->Range($oRng2);		
				$Range2->Font->{Size} = 8;
					#
				$oRng2 = "P" . $lineNb . "\:P" . int($lineNb + $nbToMerge);
				$Range2 = $Sheet->Range($oRng2);		
				$Range2->Font->{Size} = 8;
			}
		} 	  		
	}   
  
  
  
	   # Line number in column A
	   #
  $oRng1 = "A1:A" . $lineNb;
  $Range = $Sheet->Range($oRng1);
  $Range->Cells(1, 1)->{Value} = "1";
  $Range->DataSeries( {Rowcol => $xlColumns, Type => xlLinear, Step => 1 } );

  $Sheet->Columns("A:A")->EntireColumn->{Hidden} = True;
  $Sheet->Columns("K:K")->EntireColumn->{Hidden} = True;
  $Sheet->Columns("M:M")->EntireColumn->{Hidden} = True;

  #
  # DBM 1/4/08 set PrintRange
  # was printing trailing highlights. fix.
  #
  
  
$oRng1 = "B1:" . chr(71+ $extraColumns+ $ColumnCount ) .  $maxLnNb;
$Sheet->PageSetup->{PrintArea} = "$oRng1";

  $Book->SaveAs($saveAsName);
  $Book->Close;
  $Excel->Quit;
  WriteProgress($donePercent);	
  exit(0);   
}


#
# excelFormatObjResp($lineNb);
# Format the Objection and response columns
#
sub excelFormatObjResp { 
	my $lineNb = shift;
	my @myrange = shift;
	foreach $col ( @myrange ) {   # "H", "I" & "N", "O"
		#
		# Set the Bold and color for the strings
		#
	  $oRng1 = "$col" . $lineNb;
	  $Range = $Sheet->Range("$oRng1");

	  local $/; # enable localized slurp mode, 

	  $savedVal = $Range->{Value};
	  $_ = $savedVal;
	  if ( length($_) > 1 ) {

		$fullLen = length($_);
			#
			# Bold and color the objection
			#
		$Range->Characters(1, ($fullLen))->Font->{Bold} = False;
		if ( /(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Def Obj)/s ) {
		    $mylen = length($1);


		    $Range->Characters(1, ($mylen))->Font->{Bold} = True;
		    $Range->Characters(1, ($fullLen))->Font->{Color} = RGBs("$defColor");;
		}
		if ( /(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Pltf Obj)/s ) {
		    $mylen = length($1);

		    $Range->Characters(1, ($mylen))->Font->{Bold} = True;
		    $Range->Characters(1, ($fullLen))->Font->{Color} = RGBs("$pltfColor");;
		}
		
		
		$skip = $mylen;
		$found = 1;
		while ( $found ) {
		
			$_ = $savedVal;
			$found = 0;
				#
				# Bold and color more objections
				#
			if ( /(.{$skip}.+?)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Def Obj)/s ) {
			    $found = 1;
			    $startpos = length($1);
			    $mylen = length($2);
			    $mylen++;  # bold Re: .* Resp

			    $skip = $startpos + $mylen;

			   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;

			    $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$defColor");;
			}
			if ( /(.{$skip}.+?)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Pltf Obj)/s ) {
			    $found = 1;
			    $startpos = length($1);
			    $mylen = length($2);
			    $mylen++;

			    $skip = $startpos + $mylen;
			    
			   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;
			   $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$pltfColor");;
			}			
				
		}
		
		
		$skip = $mylen;
		$found = 1;
		while ( $found ) {
		
			$_ = $savedVal;
			$found = 0;
				#
				# Bold and color more objections
				#
			if ( /(.{$skip}.+?)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Def Obj)/s ) {
			    $found = 1;
			    $startpos = length($1);
			    $mylen = length($2);
			    $mylen++;  # bold Re: .* Resp

			    $skip = $startpos + $mylen;

			   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;

			    $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$defColor");;
			}
			if ( /(.{$skip}.+?)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Pltf Obj)/s ) {
			    $found = 1;
			    $startpos = length($1);
			    $mylen = length($2);
			    $mylen++;

			    $skip = $startpos + $mylen;
			    
			   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;
			   $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$pltfColor");;
			}			
				
		}
				
		
		
		
		
		
		$_ = $savedVal;
			#
			# Bold and color the response
			#
		if ( /(.*)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Def Resp)/s ) {
		    $startpos = length($1);
		    $mylen = length($2);
		    $mylen++;  # bold Re: .* Resp

		   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;

		    $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$defColor");;
		}
		if ( /(.*)(Re\: \[\d+\:\d+\-\d+\:\d+\].*?Pltf Resp)/s ) {
		    $startpos = length($1);
		    $mylen = length($2);
		    $mylen++;


		   $Range->Characters($startpos, ($mylen))->Font->{Bold} = True;
		   $Range->Characters($startpos, ($fullLen))->Font->{Color} = RGBs("$pltfColor");;
		}	
	   }
	} # for $col (N,O)
}


sub cleanExcelStrings { 
    $_ = shift;
    
#print "cleanExcelStrings=";

    $outStr = "";
    for ($zz=0; $zz<length($_); $zz++ ) {
	$mychar = ord(substr($_, $zz, 1));
	
#print "$mychar\:" . chr($mychar) . ";";	
	if ( $mychar == 226 || $mychar == 128 || $mychar == 147) {
		if ( $mychar == 147 ) {
		 $outStr = $outStr . "\x96";
		}
	} elsif ($mychar == '\r') {
		#$outStr = $outStr . chr(10);
	} elsif ($mychar == '\n') {
		$outStr = $outStr . chr(10);
	} else {
		$outStr = $outStr . chr($mychar);
	}
    }	
#print "\n";

    return( $outStr );
}

	#
	# Get parameter from XML config file
	# getConfigParam( $xmlc, "reportFormat", "noDefault" );
	#
sub getConfigParam { 
     
	#
	# Variables to Pull from XML config file
	#
    if ( defined( $_[0]->{'configure'}->{"$_[1]"} ) ) {
    	$myretval = $xmlc->{'configure'}->{"$_[1]"}->{'value'};
    } else {
    	$myretval = $_[2];
    }
    return( $myretval );	
}

	#
	# Allow RGB color value to be passed to Excel
	#
sub RGB { $_[0] | ($_[1] >> 8) | ($_[2] >> 16) }

sub RGBs { 
	$_ = $_[0];
	($r,$g,$b) = split /\,/;
	return( int($r) | (int($g) << 8) | (int($b) << 16));
}


sub WriteProgress {
    $myval = shift;
    $donePercent = $myval;
    $mystr = sprintf("%03d\n", $myval );

    if ( length($progressFile) > 0 ) {
	if (open (OUTF, ">$progressFile"  ) )
	{
		print OUTF "$mystr";
		close (OUTF);
	}
    }
}    
    

#
# Display short message describing the program and how to use it
#
sub showversion()
{
	print STDOUT "$0 $version";
	exit;
}


	
#
# Display short message describing the program and how to use it
#
sub usage()
{
	print STDERR << "EOF";

	$0 $version:  FTI Objection Report Engine.

	-in <objconfig.xml>   : Path to XML configuration file
	[-help]               : this (help) message
	[-verbose]            : verbose output
	[-version]            : display the version number
	

EOF
	exit;
}