#!perl
#############################################################################
# configftiore.pl - FTIORE config utility
#
#       Copyright (c) 2010, FTI Consulting, Inc. All rights reserved.
#
# Purpose:
#       set or clears the suppress duplicate objections in ftiore
#
#############################################################################
$version = "1.1.0 ";

use Win32;
use Win32::Registry;
use Win32::GUI;

my $Register = "Software";
my $hkey,$SubKey;

use Tk;
use Tk::Checkbutton;



#perl2exe_info CompanyName=FTI Consulting Inc.
#perl2exe_info FileDescription=FTIORE config utility
#perl2exe_info FileVersion=1.0.1
#perl2exe_info ProductVersion=1.0.1
#perl2exe_info LegalCopyright=Copyright © 2010, FTI Consulting, Inc. All rights reserved.
#perl2exe_info LegalTrademarks=TrialMax® is a registered tradmark of FTI Consulting, Inc.
#perl2exe_info ProductName=
#perl2exe_info FileDescription=

my $dos = Win32::GUI::GetPerlWindow();
Win32::GUI::Hide($dos); 

		#
		# Get SUppress Duplicate from the registry
		#

	$Register = "Software\\FTIORE\\SUPRESSDUP";
	$regSupressDup = 0;

	if ( $HKEY_LOCAL_MACHINE->Open($Register,$hkey) ) {
		$hkey->QueryValue($subkey,$value);
		$hkey->Close();
		if ($value eq '')
		{
			$regSupressDup = 0	;
		}
		else
		{
			$regSupressDup = $value ; 
		}
	} else {	
		$HKEY_LOCAL_MACHINE->Open("Software\\FTIORE",$hkey)|| die $!;
		$hkey->SetValue("SUPRESSDUP",REG_SZ,"0");
		$hkey->Close();	
		$regSupressDup = 0
	} 
	
	
	

	$top = new MainWindow();


	$f = $top->Frame;
	
   my $b1 = $top->Checkbutton(
        -text     => 'Supress Duplicate Objections',
        -variable => \$regSupressDup,
	-relief   => 'flat')->pack(@pl);	
	
	
	

	my $f4 = $top->Frame();
	$cmdbut2 = $f4->Button(-text => "Quit",  -command => sub { quit() });
	$cmdbut2->pack(-fill => 'x',-side => 'bottom', -expand => 'yes', -padx => '1c', -pady => 3);
	$f4->pack();	
	
	$cmdbut = $f4->Button(-text => "Save Settings",  -command => sub { saveSettings() });
	$cmdbut->pack(-fill => 'x',-side => 'bottom', -expand => 'yes', -padx => '1c', -pady => 3);
#	$f4->pack();
	

		#
		# Pass the control to Windows
		#
	$f->pack(-fill => 'x', -padx => '1c', -pady => 3);

		#
		# Pass the control to Windows
		#
	$f->pack(-fill => 'x', -padx => '1c', -pady => 3);

	MainLoop;

exit;


sub saveSettings() 
{
		$HKEY_LOCAL_MACHINE->Open("Software\\FTIORE",$hkey)|| die $!;
		$hkey->SetValue("SUPRESSDUP",REG_SZ,$regSupressDup);
		$hkey->Close();	
		exit;
}
 
 sub quit() 
 {
 		exit;
 }
  