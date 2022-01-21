/* CHANGES
 * Removed m_tmxMove as it crashes Visual Studio
 * 
 * this.m_paneViewer.OnRequestPresentation += new EventHandler(m_paneViewer_OnRequestPresentation); 
 * ->
 * this.m_paneViewer.OnRequestPresentation += new System.EventHandler(m_paneViewer_OnRequestPresentation); 
 * 
 * 285: this.m_paneResults = new FTI.Trialmax.Panes.CResultsPane(this.m_paneTranscripts);
 * ->
 * this.m_paneResults = new FTI.Trialmax.Panes.CResultsPane();
 */

namespace FTI.Trialmax.TmaxManager
{
    partial class TmaxManagerForm
    {
        /// <summary>Components collection required by forms designer</summary>
        private System.ComponentModel.IContainer components;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane1 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane1 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("1c818855-4b7a-4157-85aa-b613295f62b8"), new System.Guid("202de6cb-040e-4107-bc73-3b1865ce0cfd"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), 1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane2 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("6780c3bc-0feb-49b3-acc7-3ec8ab9e0343"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane3 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("ce563e1b-fa30-4ed9-8fb6-df12b8ff5223"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane4 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("04b172cf-8686-4f0e-b62e-bbe4dd3b339c"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane5 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("e6924544-31ee-49df-8529-d92f683b0ee0"), new System.Guid("de049042-f47f-4c9f-b0ee-2eb5df5a37d8"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane6 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("95101d18-0367-4a99-a97e-e415555de34b"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane7 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("7493530a-30a2-4b3a-97b5-e23484adabf8"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ca1f80c4-a2e3-430a-b556-dfbceb97651a"), -1);
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane2 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, new System.Guid("eed94c05-0eec-456e-9f0f-41ce99f52eab"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane8 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("a6c4c7d4-72e0-4395-84dd-e27e4e6ea07b"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("eed94c05-0eec-456e-9f0f-41ce99f52eab"), -1);
            Infragistics.Win.UltraWinDock.DockableGroupPane dockableGroupPane1 = new Infragistics.Win.UltraWinDock.DockableGroupPane(new System.Guid("45038e1b-01af-481a-be8f-7c8851b934b9"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("eed94c05-0eec-456e-9f0f-41ce99f52eab"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane9 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("6edb9228-5163-4921-8ac9-06d20efcc96e"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("45038e1b-01af-481a-be8f-7c8851b934b9"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane10 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("975f580a-551b-4d47-bfd7-22e4b01e6897"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("45038e1b-01af-481a-be8f-7c8851b934b9"), -1);
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane3 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane11 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("7c893a6e-fbb0-4fbf-9492-6c6fcc4413ba"), new System.Guid("2733a411-3799-4537-acec-6b7203c51f83"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), 0);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane12 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("9cdd6990-95fb-41b3-8a64-7aae1527fccc"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane13 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("fdb49793-d741-4d70-bc2c-cc4bce3afb33"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane14 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("aa0ff010-f91f-4b80-91ba-81d00d60f58c"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane15 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("8f886d34-b910-430e-8074-e449d4c21460"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane16 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("7fa9ffa3-0442-4ad8-b4fb-c9e87618146b"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane17 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("d2d25e5a-6b66-4d54-ae86-baabf89bb9f4"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane18 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("cb62c32a-0b6c-4f29-93ad-76963a4e5d65"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane19 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("ef7302e7-48cf-429c-a0a9-ddec0129b6b3"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e"), -1);
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane4 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.Floating, new System.Guid("de049042-f47f-4c9f-b0ee-2eb5df5a37d8"));
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane5 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.Floating, new System.Guid("202de6cb-040e-4107-bc73-3b1865ce0cfd"));
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane6 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.Floating, new System.Guid("2733a411-3799-4537-acec-6b7203c51f83"));
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("MainMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool1 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("FileMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool2 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("EditMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool3 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ViewMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool4 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ToolsMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool5 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("HelpMenu");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool1 = new Infragistics.Win.UltraWinToolbars.LabelTool("FixedSpacer");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool2 = new Infragistics.Win.UltraWinToolbars.LabelTool("LoadBarcodeLabel");
            Infragistics.Win.UltraWinToolbars.TextBoxTool textBoxTool1 = new Infragistics.Win.UltraWinToolbars.TextBoxTool("LoadBarcode");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool3 = new Infragistics.Win.UltraWinToolbars.LabelTool("FixedSpacer");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool6 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("FileMenu");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("NewCase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OpenCase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CloseCase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Print");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("SaveLayout");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("LoadLayout");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool7 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ImportMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool8 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ExportMenu");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool8 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent2");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool9 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent3");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool10 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent4");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool11 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent5");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool12 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool13 = new Infragistics.Win.UltraWinToolbars.ButtonTool("NewCase");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool14 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OpenCase");
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool15 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CloseCase");
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool16 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool9 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ViewMenu");
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool1 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleSourceExplorer", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool2 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleMediaTree", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool3 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleBinders", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool4 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleFilteredTree", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool5 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleProperties", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool6 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleMediaViewer", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool7 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleScriptBuilder", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool8 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleScriptReview", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool39 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleRegistrationServer", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool9 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleTuner", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool10 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleTranscripts", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool11 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleCodes", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool12 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleSearchResults", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool13 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleObjections", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool14 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleObjectionProperties", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool15 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleVersions", "");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool10 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ViewOthersMenu");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool17 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ShowAll");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool18 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OpenPresentation");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool19 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ReloadCase");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool16 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("LockPanes", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool20 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ShowAll");
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool11 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("HelpMenu");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool17 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("HelpContents", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool21 = new Infragistics.Win.UltraWinToolbars.ButtonTool("UsersManual");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool22 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OnlineSite");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool23 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ContactFTI");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool24 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AboutBox");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool25 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CheckForUpdates");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool26 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ActivateProduct");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool27 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AboutBox");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool18 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleSourceExplorer", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool19 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleMediaTree", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool20 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleBinders", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool21 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleMediaViewer", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool22 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleProperties", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool23 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleScriptBuilder", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool24 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleTranscripts", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool25 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleTuner", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool26 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleSearchResults", "");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool12 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ViewOthersMenu");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool27 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleErrorMessages", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool28 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleDiagnostics", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool29 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleErrorMessages", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool30 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleDiagnostics", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool31 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("HelpContents", "");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool32 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleVersions", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool28 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent1");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool29 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent2");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool30 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent3");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool31 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent4");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool32 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Recent5");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool33 = new Infragistics.Win.UltraWinToolbars.ButtonTool("SaveLayout");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool34 = new Infragistics.Win.UltraWinToolbars.ButtonTool("LoadLayout");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool13 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ToolsMenu");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool35 = new Infragistics.Win.UltraWinToolbars.ButtonTool("RefreshTreatments");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool36 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ValidateDatabase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool37 = new Infragistics.Win.UltraWinToolbars.ButtonTool("TrimDatabase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool98 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CompactDatabase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool38 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ManagerOptions");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool39 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PresentationOptions");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool40 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PresentationToolbars");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool41 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CaseOptions");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool99 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ShowActiveUsers");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool42 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PresentationOptions");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.TextBoxTool textBoxTool2 = new Infragistics.Win.UltraWinToolbars.TextBoxTool("LoadBarcode");
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool4 = new Infragistics.Win.UltraWinToolbars.LabelTool("FixedSpacer");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool5 = new Infragistics.Win.UltraWinToolbars.LabelTool("LoadBarcodeLabel");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool6 = new Infragistics.Win.UltraWinToolbars.LabelTool("SpringSpacer");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool43 = new Infragistics.Win.UltraWinToolbars.ButtonTool("RefreshTreatments");
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool44 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ValidateDatabase");
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool45 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CaseOptions");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool46 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ReloadCase");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool47 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Print");
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool48 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Find");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool49 = new Infragistics.Win.UltraWinToolbars.ButtonTool("FindNext");
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool14 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ImportMenu");
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool50 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiBinder");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool51 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlBinder");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool52 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiScript");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool53 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlScript");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool54 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlCaseCodes");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool55 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportCodes");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool56 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportCodesDatabase");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool57 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiObjections");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool58 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportLoadFile");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool59 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportBarcodeMap");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool15 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("ExportMenu");
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool60 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportBarcodeMap");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool61 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportXmlCaseCodes");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool62 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportAsciiObjections");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool16 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("EditMenu");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool63 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Find");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool64 = new Infragistics.Win.UltraWinToolbars.ButtonTool("FindNext");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool65 = new Infragistics.Win.UltraWinToolbars.ButtonTool("FastFilter");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool66 = new Infragistics.Win.UltraWinToolbars.ButtonTool("SetFilter");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool67 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BulkUpdate");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool68 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportBarcodeMap");
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool69 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportBarcodeMap");
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool70 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiBinder");
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool71 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiScript");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool33 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("LockPanes", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool72 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ManagerOptions");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool73 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportLoadFile");
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool74 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OpenPresentation");
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool75 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PresentationToolbars");
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool76 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Debug1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool77 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Debug2");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool17 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Debug");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool78 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Debug1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool79 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Debug2");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool80 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ActivateProduct");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool81 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CheckForUpdates");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool82 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ContactFTI");
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool83 = new Infragistics.Win.UltraWinToolbars.ButtonTool("UsersManual");
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool34 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleCodes", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool84 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportCodes");
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool35 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleFilteredTree", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool85 = new Infragistics.Win.UltraWinToolbars.ButtonTool("SetFilter");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool86 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlScript");
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool87 = new Infragistics.Win.UltraWinToolbars.ButtonTool("OnlineSite");
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool88 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlCaseCodes");
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool89 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportXmlCaseCodes");
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool90 = new Infragistics.Win.UltraWinToolbars.ButtonTool("FastFilter");
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool91 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportCodesDatabase");
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool92 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportXmlBinder");
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool93 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BulkUpdate");
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool94 = new Infragistics.Win.UltraWinToolbars.ButtonTool("TrimDatabase");
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool36 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleObjections", "");
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool37 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleScriptReview", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool95 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ImportAsciiObjections");
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool96 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ExportAsciiObjections");
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool38 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleObjectionProperties", "");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool97 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CompactDatabase");
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool100 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ShowActiveUsers");
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.StateButtonTool stateButtonTool40 = new Infragistics.Win.UltraWinToolbars.StateButtonTool("ToggleRegistrationServer", "");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TmaxManagerForm));
            this.m_paneRegistration = new FTI.Trialmax.Panes.RegistrationPane();
            this.m_paneTuner = new FTI.Trialmax.Panes.CTunePane();
            this.m_paneProperties = new FTI.Trialmax.Panes.CPropertiesPane();
            this.m_paneVersions = new FTI.Trialmax.Panes.CMessagePane();
            this.m_paneCodes = new FTI.Trialmax.Panes.CCodesPane();
            this.m_paneObjectionProperties = new FTI.Trialmax.Panes.CObjectionPropertiesPane();
            this.m_paneHelp = new FTI.Trialmax.Panes.CHelpPane();
            this.m_paneBinders = new FTI.Trialmax.Panes.CBinderTree();
            this.m_paneMedia = new FTI.Trialmax.Panes.CMediaTree();
            this.m_paneFiltered = new FTI.Trialmax.Panes.CFilteredTree();
            this.m_paneObjections = new FTI.Trialmax.Panes.CObjectionsPane();
            this.m_paneViewer = new FTI.Trialmax.Panes.CMediaViewer();
            this.m_paneScripts = new FTI.Trialmax.Panes.CScriptBuilder();
            this.m_paneTranscripts = new FTI.Trialmax.Panes.CTranscriptPane();
            this.m_paneSource = new FTI.Trialmax.Panes.CExplorerPane();
            this.m_paneResults = new FTI.Trialmax.Panes.CResultsPane();
            this.m_paneScriptReview = new FTI.Trialmax.Panes.CScriptReviewPane();
            this.m_paneErrors = new FTI.Trialmax.Panes.CMessagePane();
            this.m_paneDiagnostics = new FTI.Trialmax.Panes.CMessagePane();
            this.m_ctrlUltraDockManager = new Infragistics.Win.UltraWinDock.UltraDockManager(this.components);
            this._TmaxManagerFormUnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._TmaxManagerFormUnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._TmaxManagerFormUnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._TmaxManagerFormUnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._TmaxManagerFormAutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
            this.m_ctrlSmallImages = new System.Windows.Forms.ImageList(this.components);
            this._TmaxManagerForm_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.m_ctrlUltraToolbarManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._TmaxManagerForm_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._TmaxManagerForm_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.m_ctrlMainFillPanel = new System.Windows.Forms.Panel();
            this.m_tmxView = new FTI.Trialmax.ActiveX.CTmxView();
            this.m_ctrlScreenCapture = new AxTM_GRAB6Lib.AxTMGrab6();
            this.m_ctrlPresentation = new FTI.Trialmax.ActiveX.CTmxShare();
            this.m_tmxPrint = new AxTM_PRINT6Lib.AxTMPrint6();
            this.windowDockingArea6 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.dockableWindow1 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow2 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow3 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow4 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow5 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow12 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow19 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow8 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow10 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow11 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.windowDockingArea2 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.dockableWindow14 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow15 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow16 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow17 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow18 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow6 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow7 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow9 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow13 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.windowDockingArea1 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.windowDockingArea3 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.windowDockingArea5 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.windowDockingArea7 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlUltraDockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlUltraToolbarManager)).BeginInit();
            this.m_ctrlMainFillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlScreenCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tmxPrint)).BeginInit();
            this.windowDockingArea6.SuspendLayout();
            this.dockableWindow1.SuspendLayout();
            this.dockableWindow2.SuspendLayout();
            this.dockableWindow3.SuspendLayout();
            this.dockableWindow4.SuspendLayout();
            this.dockableWindow5.SuspendLayout();
            this.dockableWindow12.SuspendLayout();
            this.dockableWindow19.SuspendLayout();
            this.dockableWindow8.SuspendLayout();
            this.dockableWindow10.SuspendLayout();
            this.dockableWindow11.SuspendLayout();
            this.windowDockingArea2.SuspendLayout();
            this.dockableWindow14.SuspendLayout();
            this.dockableWindow15.SuspendLayout();
            this.dockableWindow16.SuspendLayout();
            this.dockableWindow17.SuspendLayout();
            this.dockableWindow18.SuspendLayout();
            this.dockableWindow6.SuspendLayout();
            this.dockableWindow7.SuspendLayout();
            this.dockableWindow9.SuspendLayout();
            this.dockableWindow13.SuspendLayout();
            this.windowDockingArea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_paneRegistration
            // 
            this.m_paneRegistration.AllowDrop = true;
            this.m_paneRegistration.ApplicationOptions = null;
            this.m_paneRegistration.AsyncCommandArgs = null;
            this.m_paneRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.m_paneRegistration.CaseCodes = null;
            this.m_paneRegistration.CaseOptions = null;
            this.m_paneRegistration.Database = null;
            this.m_paneRegistration.Filtered = null;
            this.m_paneRegistration.Location = new System.Drawing.Point(2, 28);
            this.m_paneRegistration.MediaTypes = null;
            this.m_paneRegistration.Name = "m_paneRegistration";
            this.m_paneRegistration.PaneId = 0;
            this.m_paneRegistration.PaneName = "";
            this.m_paneRegistration.PaneVisible = false;
            this.m_paneRegistration.PresentationOptions = null;
            this.m_paneRegistration.PresentationOptionsFilename = "";
            this.m_paneRegistration.RegistrationOptions = null;
            this.m_paneRegistration.ReportManager = null;
            this.m_paneRegistration.Size = new System.Drawing.Size(446, 859);
            this.m_paneRegistration.SourceTypes = null;
            this.m_paneRegistration.StationOptions = null;
            this.m_paneRegistration.TabIndex = 33;
            this.m_paneRegistration.TmaxClipboard = null;
            this.m_paneRegistration.TmaxProductManager = null;
            this.m_paneRegistration.TmaxRegistry = null;
            // 
            // m_paneTuner
            // 
            this.m_paneTuner.ApplicationOptions = null;
            this.m_paneTuner.AsyncCommandArgs = null;
            this.m_paneTuner.CaseCodes = null;
            this.m_paneTuner.CaseOptions = null;
            this.m_paneTuner.Database = null;
            this.m_paneTuner.Filtered = null;
            this.m_paneTuner.Location = new System.Drawing.Point(2, 28);
            this.m_paneTuner.MediaTypes = null;
            this.m_paneTuner.Name = "m_paneTuner";
            this.m_paneTuner.PaneId = 0;
            this.m_paneTuner.PaneName = "Tuner Pane";
            this.m_paneTuner.PaneVisible = false;
            this.m_paneTuner.PresentationOptions = null;
            this.m_paneTuner.PresentationOptionsFilename = "";
            this.m_paneTuner.RegistrationOptions = null;
            this.m_paneTuner.ReportManager = null;
            this.m_paneTuner.Size = new System.Drawing.Size(272, 470);
            this.m_paneTuner.SourceTypes = null;
            this.m_paneTuner.StationOptions = null;
            this.m_paneTuner.TabIndex = 24;
            this.m_paneTuner.TmaxClipboard = null;
            this.m_paneTuner.TmaxProductManager = null;
            this.m_paneTuner.TmaxRegistry = null;
            // 
            // m_paneProperties
            // 
            this.m_paneProperties.ApplicationOptions = null;
            this.m_paneProperties.AsyncCommandArgs = null;
            this.m_paneProperties.CaseCodes = null;
            this.m_paneProperties.CaseOptions = null;
            this.m_paneProperties.Database = null;
            this.m_paneProperties.Filtered = null;
            this.m_paneProperties.Location = new System.Drawing.Point(2, 28);
            this.m_paneProperties.MediaTypes = null;
            this.m_paneProperties.Name = "m_paneProperties";
            this.m_paneProperties.PaneId = 0;
            this.m_paneProperties.PaneName = "Properties Pane";
            this.m_paneProperties.PaneVisible = false;
            this.m_paneProperties.PresentationOptions = null;
            this.m_paneProperties.PresentationOptionsFilename = "";
            this.m_paneProperties.RegistrationOptions = null;
            this.m_paneProperties.ReportManager = null;
            this.m_paneProperties.Size = new System.Drawing.Size(272, 470);
            this.m_paneProperties.SourceTypes = null;
            this.m_paneProperties.StationOptions = null;
            this.m_paneProperties.TabIndex = 20;
            this.m_paneProperties.TmaxClipboard = null;
            this.m_paneProperties.TmaxProductManager = null;
            this.m_paneProperties.TmaxRegistry = null;
            // 
            // m_paneVersions
            // 
            this.m_paneVersions.AddTop = false;
            this.m_paneVersions.ApplicationOptions = null;
            this.m_paneVersions.AsyncCommandArgs = null;
            this.m_paneVersions.CaseCodes = null;
            this.m_paneVersions.CaseOptions = null;
            this.m_paneVersions.ClearOnDblClick = false;
            this.m_paneVersions.Database = null;
            this.m_paneVersions.Filtered = null;
            this.m_paneVersions.Format = FTI.Trialmax.Controls.TmaxMessageFormats.Version;
            this.m_paneVersions.Location = new System.Drawing.Point(2, 28);
            this.m_paneVersions.MaxRows = 64;
            this.m_paneVersions.MediaTypes = null;
            this.m_paneVersions.Name = "m_paneVersions";
            this.m_paneVersions.PaneId = 0;
            this.m_paneVersions.PaneName = "Versions Pane";
            this.m_paneVersions.PaneVisible = false;
            this.m_paneVersions.PresentationOptions = null;
            this.m_paneVersions.PresentationOptionsFilename = "";
            this.m_paneVersions.RegistrationOptions = null;
            this.m_paneVersions.ReportManager = null;
            this.m_paneVersions.Size = new System.Drawing.Size(272, 470);
            this.m_paneVersions.SourceTypes = null;
            this.m_paneVersions.StationOptions = null;
            this.m_paneVersions.TabIndex = 18;
            this.m_paneVersions.TmaxClipboard = null;
            this.m_paneVersions.TmaxProductManager = null;
            this.m_paneVersions.TmaxRegistry = null;
            // 
            // m_paneCodes
            // 
            this.m_paneCodes.ApplicationOptions = null;
            this.m_paneCodes.AsyncCommandArgs = null;
            this.m_paneCodes.CaseCodes = null;
            this.m_paneCodes.CaseOptions = null;
            this.m_paneCodes.Database = null;
            this.m_paneCodes.Filtered = null;
            this.m_paneCodes.Location = new System.Drawing.Point(2, 28);
            this.m_paneCodes.MediaTypes = null;
            this.m_paneCodes.Name = "m_paneCodes";
            this.m_paneCodes.PaneId = 0;
            this.m_paneCodes.PaneName = "Codes Pane";
            this.m_paneCodes.PaneVisible = false;
            this.m_paneCodes.PresentationOptions = null;
            this.m_paneCodes.PresentationOptionsFilename = "";
            this.m_paneCodes.RegistrationOptions = null;
            this.m_paneCodes.ReportManager = null;
            this.m_paneCodes.Size = new System.Drawing.Size(272, 796);
            this.m_paneCodes.SourceTypes = null;
            this.m_paneCodes.StationOptions = null;
            this.m_paneCodes.TabIndex = 31;
            this.m_paneCodes.TmaxClipboard = null;
            this.m_paneCodes.TmaxProductManager = null;
            this.m_paneCodes.TmaxRegistry = null;
            // 
            // m_paneObjectionProperties
            // 
            this.m_paneObjectionProperties.ApplicationOptions = null;
            this.m_paneObjectionProperties.AsyncCommandArgs = null;
            this.m_paneObjectionProperties.CaseCodes = null;
            this.m_paneObjectionProperties.CaseOptions = null;
            this.m_paneObjectionProperties.Database = null;
            this.m_paneObjectionProperties.Filtered = null;
            this.m_paneObjectionProperties.Location = new System.Drawing.Point(2, 28);
            this.m_paneObjectionProperties.MediaTypes = null;
            this.m_paneObjectionProperties.Name = "m_paneObjectionProperties";
            this.m_paneObjectionProperties.PaneId = 0;
            this.m_paneObjectionProperties.PaneName = "Objection Properties";
            this.m_paneObjectionProperties.PaneVisible = false;
            this.m_paneObjectionProperties.PresentationOptions = null;
            this.m_paneObjectionProperties.PresentationOptionsFilename = "";
            this.m_paneObjectionProperties.RegistrationOptions = null;
            this.m_paneObjectionProperties.ReportManager = null;
            this.m_paneObjectionProperties.Size = new System.Drawing.Size(272, 461);
            this.m_paneObjectionProperties.SourceTypes = null;
            this.m_paneObjectionProperties.StationOptions = null;
            this.m_paneObjectionProperties.TabIndex = 34;
            this.m_paneObjectionProperties.TmaxClipboard = null;
            this.m_paneObjectionProperties.TmaxProductManager = null;
            this.m_paneObjectionProperties.TmaxRegistry = null;
            // 
            // m_paneHelp
            // 
            this.m_paneHelp.ApplicationOptions = null;
            this.m_paneHelp.AsyncCommandArgs = null;
            this.m_paneHelp.BackColor = System.Drawing.SystemColors.Control;
            this.m_paneHelp.CaseCodes = null;
            this.m_paneHelp.CaseOptions = null;
            this.m_paneHelp.Database = null;
            this.m_paneHelp.Filtered = null;
            this.m_paneHelp.Location = new System.Drawing.Point(2, 28);
            this.m_paneHelp.MediaTypes = null;
            this.m_paneHelp.Name = "m_paneHelp";
            this.m_paneHelp.PaneId = 0;
            this.m_paneHelp.PaneName = "Help Pane";
            this.m_paneHelp.PaneVisible = false;
            this.m_paneHelp.PresentationOptions = null;
            this.m_paneHelp.PresentationOptionsFilename = "";
            this.m_paneHelp.RegistrationOptions = null;
            this.m_paneHelp.ReportManager = null;
            this.m_paneHelp.Size = new System.Drawing.Size(446, 796);
            this.m_paneHelp.SourceTypes = null;
            this.m_paneHelp.StationOptions = null;
            this.m_paneHelp.TabIndex = 29;
            this.m_paneHelp.TmaxClipboard = null;
            this.m_paneHelp.TmaxProductManager = null;
            this.m_paneHelp.TmaxRegistry = null;
            // 
            // m_paneBinders
            // 
            this.m_paneBinders.AddFromPresentation = false;
            this.m_paneBinders.AllowDrop = true;
            this.m_paneBinders.ApplicationOptions = null;
            this.m_paneBinders.AsyncCommandArgs = null;
            this.m_paneBinders.BackColor = System.Drawing.SystemColors.Window;
            this.m_paneBinders.CaseCodes = null;
            this.m_paneBinders.CaseOptions = null;
            this.m_paneBinders.CheckBoxes = false;
            this.m_paneBinders.Database = null;
            this.m_paneBinders.EnableContextMenu = true;
            this.m_paneBinders.EnableDragDrop = true;
            this.m_paneBinders.Filtered = null;
            this.m_paneBinders.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_paneBinders.Location = new System.Drawing.Point(2, 28);
            this.m_paneBinders.MediaTypes = null;
            this.m_paneBinders.Name = "m_paneBinders";
            this.m_paneBinders.PaneId = 3;
            this.m_paneBinders.PaneName = "Binders Pane";
            this.m_paneBinders.PaneVisible = false;
            this.m_paneBinders.PresentationOptions = null;
            this.m_paneBinders.PresentationOptionsFilename = "";
            this.m_paneBinders.PrimaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.MediaId;
            this.m_paneBinders.QuaternaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneBinders.RegistrationOptions = null;
            this.m_paneBinders.ReportManager = null;
            this.m_paneBinders.SecondaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneBinders.Size = new System.Drawing.Size(293, 272);
            this.m_paneBinders.SourceTypes = null;
            this.m_paneBinders.StationOptions = null;
            this.m_paneBinders.SuperNodeSize = 0;
            this.m_paneBinders.TabIndex = 12;
            this.m_paneBinders.TertiaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneBinders.TmaxClipboard = null;
            this.m_paneBinders.TmaxProductManager = null;
            this.m_paneBinders.TmaxRegistry = null;
            // 
            // m_paneMedia
            // 
            this.m_paneMedia.AllowDrop = true;
            this.m_paneMedia.ApplicationOptions = null;
            this.m_paneMedia.AsyncCommandArgs = null;
            this.m_paneMedia.BackColor = System.Drawing.SystemColors.Window;
            this.m_paneMedia.CaseCodes = null;
            this.m_paneMedia.CaseOptions = null;
            this.m_paneMedia.CheckBoxes = false;
            this.m_paneMedia.Database = null;
            this.m_paneMedia.EnableContextMenu = true;
            this.m_paneMedia.EnableDragDrop = true;
            this.m_paneMedia.Filtered = null;
            this.m_paneMedia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_paneMedia.Location = new System.Drawing.Point(2, 28);
            this.m_paneMedia.MediaTypes = null;
            this.m_paneMedia.Name = "m_paneMedia";
            this.m_paneMedia.PaneId = 1;
            this.m_paneMedia.PaneName = "Media Pane";
            this.m_paneMedia.PaneVisible = false;
            this.m_paneMedia.PresentationOptions = null;
            this.m_paneMedia.PresentationOptionsFilename = "";
            this.m_paneMedia.PrimaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.MediaId;
            this.m_paneMedia.QuaternaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneMedia.RegistrationOptions = null;
            this.m_paneMedia.ReportManager = null;
            this.m_paneMedia.SecondaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Name;
            this.m_paneMedia.Size = new System.Drawing.Size(289, 548);
            this.m_paneMedia.SourceTypes = null;
            this.m_paneMedia.StationOptions = null;
            this.m_paneMedia.SuperNodeSize = 0;
            this.m_paneMedia.TabIndex = 13;
            this.m_paneMedia.TertiaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneMedia.TmaxClipboard = null;
            this.m_paneMedia.TmaxProductManager = null;
            this.m_paneMedia.TmaxRegistry = null;
            // 
            // m_paneFiltered
            // 
            this.m_paneFiltered.AllowDrop = true;
            this.m_paneFiltered.ApplicationOptions = null;
            this.m_paneFiltered.AsyncCommandArgs = null;
            this.m_paneFiltered.BackColor = System.Drawing.SystemColors.Control;
            this.m_paneFiltered.CaseCodes = null;
            this.m_paneFiltered.CaseOptions = null;
            this.m_paneFiltered.CheckBoxes = false;
            this.m_paneFiltered.Database = null;
            this.m_paneFiltered.EnableContextMenu = true;
            this.m_paneFiltered.EnableDragDrop = true;
            this.m_paneFiltered.Filtered = null;
            this.m_paneFiltered.Location = new System.Drawing.Point(2, 28);
            this.m_paneFiltered.MediaTypes = null;
            this.m_paneFiltered.Name = "m_paneFiltered";
            this.m_paneFiltered.PaneId = 0;
            this.m_paneFiltered.PaneName = "Filtered Pane";
            this.m_paneFiltered.PaneVisible = false;
            this.m_paneFiltered.PresentationOptions = null;
            this.m_paneFiltered.PresentationOptionsFilename = "";
            this.m_paneFiltered.PrimaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.MediaId;
            this.m_paneFiltered.QuaternaryTextMode = ((FTI.Shared.Trialmax.TmaxTextModes)((FTI.Shared.Trialmax.TmaxTextModes.Barcode | FTI.Shared.Trialmax.TmaxTextModes.Name)));
            this.m_paneFiltered.RegistrationOptions = null;
            this.m_paneFiltered.ReportManager = null;
            this.m_paneFiltered.SecondaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneFiltered.Size = new System.Drawing.Size(293, 138);
            this.m_paneFiltered.SourceTypes = null;
            this.m_paneFiltered.StationOptions = null;
            this.m_paneFiltered.SuperNodeSize = 0;
            this.m_paneFiltered.TabIndex = 31;
            this.m_paneFiltered.TertiaryTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneFiltered.TmaxClipboard = null;
            this.m_paneFiltered.TmaxProductManager = null;
            this.m_paneFiltered.TmaxRegistry = null;
            // 
            // m_paneObjections
            // 
            this.m_paneObjections.ApplicationOptions = null;
            this.m_paneObjections.AsyncCommandArgs = null;
            this.m_paneObjections.CaseCodes = null;
            this.m_paneObjections.CaseOptions = null;
            this.m_paneObjections.Database = null;
            this.m_paneObjections.Filtered = null;
            this.m_paneObjections.Location = new System.Drawing.Point(2, 28);
            this.m_paneObjections.MediaTypes = null;
            this.m_paneObjections.Name = "m_paneObjections";
            this.m_paneObjections.PaneId = 0;
            this.m_paneObjections.PaneName = "Objections Pane";
            this.m_paneObjections.PaneVisible = false;
            this.m_paneObjections.PresentationOptions = null;
            this.m_paneObjections.PresentationOptionsFilename = "";
            this.m_paneObjections.RegistrationOptions = null;
            this.m_paneObjections.ReportManager = null;
            this.m_paneObjections.Size = new System.Drawing.Size(993, 634);
            this.m_paneObjections.SourceTypes = null;
            this.m_paneObjections.StationOptions = null;
            this.m_paneObjections.TabIndex = 34;
            this.m_paneObjections.TmaxClipboard = null;
            this.m_paneObjections.TmaxProductManager = null;
            this.m_paneObjections.TmaxRegistry = null;
            // 
            // m_paneViewer
            // 
            this.m_paneViewer.ApplicationOptions = null;
            this.m_paneViewer.AsyncCommandArgs = null;
            this.m_paneViewer.CaseCodes = null;
            this.m_paneViewer.CaseOptions = null;
            this.m_paneViewer.Database = null;
            this.m_paneViewer.Filtered = null;
            this.m_paneViewer.Location = new System.Drawing.Point(2, 28);
            this.m_paneViewer.MediaTypes = null;
            this.m_paneViewer.Name = "m_paneViewer";
            this.m_paneViewer.PaneId = 0;
            this.m_paneViewer.PaneName = "Viewer Pane";
            this.m_paneViewer.PaneVisible = false;
            this.m_paneViewer.PresentationOptions = null;
            this.m_paneViewer.PresentationOptionsFilename = "";
            this.m_paneViewer.RegistrationOptions = null;
            this.m_paneViewer.ReportManager = null;
            this.m_paneViewer.Size = new System.Drawing.Size(632, 314);
            this.m_paneViewer.SourceTypes = null;
            this.m_paneViewer.StationOptions = null;
            this.m_paneViewer.TabIndex = 21;
            this.m_paneViewer.TmaxClipboard = null;
            this.m_paneViewer.TmaxProductManager = null;
            this.m_paneViewer.TmaxRegistry = null;
            this.m_paneViewer.OnRequestPresentation += new System.EventHandler(this.m_paneViewer_OnRequestPresentation);
            // 
            // m_paneScripts
            // 
            this.m_paneScripts.AllowDrop = true;
            this.m_paneScripts.ApplicationOptions = null;
            this.m_paneScripts.AsyncCommandArgs = null;
            this.m_paneScripts.CaseCodes = null;
            this.m_paneScripts.CaseOptions = null;
            this.m_paneScripts.Columns = 2;
            this.m_paneScripts.Database = null;
            this.m_paneScripts.Filtered = null;
            this.m_paneScripts.Location = new System.Drawing.Point(2, 28);
            this.m_paneScripts.MediaTypes = null;
            this.m_paneScripts.Name = "m_paneScripts";
            this.m_paneScripts.PaneId = 0;
            this.m_paneScripts.PaneName = "Scripts Pane";
            this.m_paneScripts.PaneVisible = false;
            this.m_paneScripts.PresentationOptions = null;
            this.m_paneScripts.PresentationOptionsFilename = "";
            this.m_paneScripts.RegistrationOptions = null;
            this.m_paneScripts.ReportManager = null;
            this.m_paneScripts.SceneSeparatorSize = 8;
            this.m_paneScripts.SceneTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneScripts.Size = new System.Drawing.Size(632, 314);
            this.m_paneScripts.SourceTypes = null;
            this.m_paneScripts.StationOptions = null;
            this.m_paneScripts.StatusTextMode = FTI.Shared.Trialmax.TmaxTextModes.Barcode;
            this.m_paneScripts.TabIndex = 22;
            this.m_paneScripts.TmaxClipboard = null;
            this.m_paneScripts.TmaxProductManager = null;
            this.m_paneScripts.TmaxRegistry = null;
            // 
            // m_paneTranscripts
            // 
            this.m_paneTranscripts.ApplicationOptions = null;
            this.m_paneTranscripts.AsyncCommandArgs = null;
            this.m_paneTranscripts.CaseCodes = null;
            this.m_paneTranscripts.CaseOptions = null;
            this.m_paneTranscripts.Database = null;
            this.m_paneTranscripts.Filtered = null;
            this.m_paneTranscripts.Location = new System.Drawing.Point(2, 28);
            this.m_paneTranscripts.MediaTypes = null;
            this.m_paneTranscripts.Name = "m_paneTranscripts";
            this.m_paneTranscripts.PaneId = 0;
            this.m_paneTranscripts.PaneName = "Transcripts Pane";
            this.m_paneTranscripts.PaneVisible = false;
            this.m_paneTranscripts.PresentationOptions = null;
            this.m_paneTranscripts.PresentationOptionsFilename = "";
            this.m_paneTranscripts.RegistrationOptions = null;
            this.m_paneTranscripts.ReportManager = null;
            this.m_paneTranscripts.Size = new System.Drawing.Size(1032, 310);
            this.m_paneTranscripts.SourceTypes = null;
            this.m_paneTranscripts.StationOptions = null;
            this.m_paneTranscripts.TabIndex = 23;
            this.m_paneTranscripts.TmaxClipboard = null;
            this.m_paneTranscripts.TmaxProductManager = null;
            this.m_paneTranscripts.TmaxRegistry = null;
            // 
            // m_paneSource
            // 
            this.m_paneSource.ApplicationOptions = null;
            this.m_paneSource.AsyncCommandArgs = null;
            this.m_paneSource.BackColor = System.Drawing.SystemColors.Control;
            this.m_paneSource.CaseCodes = null;
            this.m_paneSource.CaseOptions = null;
            this.m_paneSource.CtrlWidthRatio = 0.5F;
            this.m_paneSource.Database = null;
            this.m_paneSource.Filtered = null;
            this.m_paneSource.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_paneSource.Location = new System.Drawing.Point(2, 28);
            this.m_paneSource.MediaTypes = null;
            this.m_paneSource.Name = "m_paneSource";
            this.m_paneSource.PaneId = 2;
            this.m_paneSource.PaneName = "Source Explorer";
            this.m_paneSource.PaneVisible = false;
            this.m_paneSource.PresentationOptions = null;
            this.m_paneSource.PresentationOptionsFilename = "";
            this.m_paneSource.RegistrationOptions = null;
            this.m_paneSource.ReportManager = null;
            this.m_paneSource.ShowHidden = false;
            this.m_paneSource.ShowTree = true;
            this.m_paneSource.Size = new System.Drawing.Size(972, 249);
            this.m_paneSource.SourceType = FTI.Shared.Trialmax.RegSourceTypes.AllFiles;
            this.m_paneSource.SourceTypes = null;
            this.m_paneSource.StationOptions = null;
            this.m_paneSource.TabIndex = 0;
            this.m_paneSource.TmaxClipboard = null;
            this.m_paneSource.TmaxProductManager = null;
            this.m_paneSource.TmaxRegistry = null;
            // 
            // m_paneResults
            // 
            this.m_paneResults.ApplicationOptions = null;
            this.m_paneResults.AsyncCommandArgs = null;
            this.m_paneResults.BackColor = System.Drawing.SystemColors.Window;
            this.m_paneResults.CaseCodes = null;
            this.m_paneResults.CaseOptions = null;
            this.m_paneResults.Database = null;
            this.m_paneResults.Filtered = null;
            this.m_paneResults.Location = new System.Drawing.Point(2, 28);
            this.m_paneResults.MediaTypes = null;
            this.m_paneResults.Name = "m_paneResults";
            this.m_paneResults.PaneId = 0;
            this.m_paneResults.PaneName = "Results Pane";
            this.m_paneResults.PaneVisible = false;
            this.m_paneResults.PresentationOptions = null;
            this.m_paneResults.PresentationOptionsFilename = "";
            this.m_paneResults.RegistrationOptions = null;
            this.m_paneResults.ReportManager = null;
            this.m_paneResults.Size = new System.Drawing.Size(634, 249);
            this.m_paneResults.SourceTypes = null;
            this.m_paneResults.StationOptions = null;
            this.m_paneResults.TabIndex = 28;
            this.m_paneResults.TmaxClipboard = null;
            this.m_paneResults.TmaxProductManager = null;
            this.m_paneResults.TmaxRegistry = null;
            // 
            // m_paneScriptReview
            // 
            this.m_paneScriptReview.ApplicationOptions = null;
            this.m_paneScriptReview.AsyncCommandArgs = null;
            this.m_paneScriptReview.CaseCodes = null;
            this.m_paneScriptReview.CaseOptions = null;
            this.m_paneScriptReview.Database = null;
            this.m_paneScriptReview.Filtered = null;
            this.m_paneScriptReview.Location = new System.Drawing.Point(2, 28);
            this.m_paneScriptReview.MediaTypes = null;
            this.m_paneScriptReview.Name = "m_paneScriptReview";
            this.m_paneScriptReview.PaneId = 0;
            this.m_paneScriptReview.PaneName = "ScriptReview Pane";
            this.m_paneScriptReview.PaneVisible = false;
            this.m_paneScriptReview.PresentationOptions = null;
            this.m_paneScriptReview.PresentationOptionsFilename = "";
            this.m_paneScriptReview.RegistrationOptions = null;
            this.m_paneScriptReview.ReportManager = null;
            this.m_paneScriptReview.Size = new System.Drawing.Size(632, 314);
            this.m_paneScriptReview.SourceTypes = null;
            this.m_paneScriptReview.StationOptions = null;
            this.m_paneScriptReview.TabIndex = 34;
            this.m_paneScriptReview.TmaxClipboard = null;
            this.m_paneScriptReview.TmaxProductManager = null;
            this.m_paneScriptReview.TmaxRegistry = null;
            // 
            // m_paneErrors
            // 
            this.m_paneErrors.AddTop = true;
            this.m_paneErrors.ApplicationOptions = null;
            this.m_paneErrors.AsyncCommandArgs = null;
            this.m_paneErrors.CaseCodes = null;
            this.m_paneErrors.CaseOptions = null;
            this.m_paneErrors.ClearOnDblClick = true;
            this.m_paneErrors.Database = null;
            this.m_paneErrors.Filtered = null;
            this.m_paneErrors.Format = FTI.Trialmax.Controls.TmaxMessageFormats.ErrorArgs;
            this.m_paneErrors.Location = new System.Drawing.Point(2, 28);
            this.m_paneErrors.MaxRows = 32;
            this.m_paneErrors.MediaTypes = null;
            this.m_paneErrors.Name = "m_paneErrors";
            this.m_paneErrors.PaneId = 0;
            this.m_paneErrors.PaneName = "Errors Pane";
            this.m_paneErrors.PaneVisible = false;
            this.m_paneErrors.PresentationOptions = null;
            this.m_paneErrors.PresentationOptionsFilename = "";
            this.m_paneErrors.RegistrationOptions = null;
            this.m_paneErrors.ReportManager = null;
            this.m_paneErrors.Size = new System.Drawing.Size(972, 249);
            this.m_paneErrors.SourceTypes = null;
            this.m_paneErrors.StationOptions = null;
            this.m_paneErrors.TabIndex = 15;
            this.m_paneErrors.TmaxClipboard = null;
            this.m_paneErrors.TmaxProductManager = null;
            this.m_paneErrors.TmaxRegistry = null;
            // 
            // m_paneDiagnostics
            // 
            this.m_paneDiagnostics.AddTop = true;
            this.m_paneDiagnostics.ApplicationOptions = null;
            this.m_paneDiagnostics.AsyncCommandArgs = null;
            this.m_paneDiagnostics.CaseCodes = null;
            this.m_paneDiagnostics.CaseOptions = null;
            this.m_paneDiagnostics.ClearOnDblClick = true;
            this.m_paneDiagnostics.Database = null;
            this.m_paneDiagnostics.Filtered = null;
            this.m_paneDiagnostics.Format = FTI.Trialmax.Controls.TmaxMessageFormats.DiagnosticArgs;
            this.m_paneDiagnostics.Location = new System.Drawing.Point(2, 28);
            this.m_paneDiagnostics.MaxRows = 64;
            this.m_paneDiagnostics.MediaTypes = null;
            this.m_paneDiagnostics.Name = "m_paneDiagnostics";
            this.m_paneDiagnostics.PaneId = 0;
            this.m_paneDiagnostics.PaneName = "Diagnostics Pane";
            this.m_paneDiagnostics.PaneVisible = false;
            this.m_paneDiagnostics.PresentationOptions = null;
            this.m_paneDiagnostics.PresentationOptionsFilename = "";
            this.m_paneDiagnostics.RegistrationOptions = null;
            this.m_paneDiagnostics.ReportManager = null;
            this.m_paneDiagnostics.Size = new System.Drawing.Size(1032, 634);
            this.m_paneDiagnostics.SourceTypes = null;
            this.m_paneDiagnostics.StationOptions = null;
            this.m_paneDiagnostics.TabIndex = 14;
            this.m_paneDiagnostics.TmaxClipboard = null;
            this.m_paneDiagnostics.TmaxProductManager = null;
            this.m_paneDiagnostics.TmaxRegistry = null;
            // 
            // m_ctrlUltraDockManager
            // 
            this.m_ctrlUltraDockManager.AnimationEnabled = false;
            this.m_ctrlUltraDockManager.AutoHideDelay = 1000;
            this.m_ctrlUltraDockManager.DefaultGroupSettings.TabStyle = Infragistics.Win.UltraWinTabs.TabStyle.Excel;
            appearance1.FontData.BoldAsString = "True";
            this.m_ctrlUltraDockManager.DefaultPaneSettings.ActiveTabAppearance = appearance1;
            this.m_ctrlUltraDockManager.DefaultPaneSettings.AllowPin = Infragistics.Win.DefaultableBoolean.False;
            this.m_ctrlUltraDockManager.DefaultPaneSettings.BorderStylePane = Infragistics.Win.UIElementBorderStyle.Etched;
            appearance2.ForeColor = System.Drawing.SystemColors.ControlText;
            appearance2.ForeColorDisabled = System.Drawing.SystemColors.ControlText;
            this.m_ctrlUltraDockManager.DefaultPaneSettings.TabAppearance = appearance2;
            dockAreaPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup;
            dockAreaPane1.DockedBefore = new System.Guid("eed94c05-0eec-456e-9f0f-41ce99f52eab");
            dockableControlPane1.Control = this.m_paneRegistration;
            dockableControlPane1.Key = "RegistrationServer";
            dockableControlPane1.OriginalControlBounds = new System.Drawing.Rectangle(134, 80, 576, 258);
            dockableControlPane1.Size = new System.Drawing.Size(980, 81);
            dockableControlPane1.Text = "Registration Server";
            dockableControlPane1.TextTab = "Registration";
            dockableControlPane2.Control = this.m_paneTuner;
            dockableControlPane2.Key = "Tuner";
            dockableControlPane2.OriginalControlBounds = new System.Drawing.Rectangle(108, 10, 140, 44);
            dockableControlPane2.Size = new System.Drawing.Size(285, 240);
            dockableControlPane2.Text = "Tuner";
            dockableControlPane2.TextTab = "Tuner";
            dockableControlPane3.Control = this.m_paneProperties;
            dockableControlPane3.Key = "Properties";
            dockableControlPane3.OriginalControlBounds = new System.Drawing.Rectangle(158, 8, 140, 44);
            dockableControlPane3.Size = new System.Drawing.Size(285, 240);
            dockableControlPane3.Text = "Properties";
            dockableControlPane3.TextTab = "Properties";
            dockableControlPane4.Control = this.m_paneVersions;
            dockableControlPane4.Key = "Versions";
            dockableControlPane4.OriginalControlBounds = new System.Drawing.Rectangle(8, 228, 140, 44);
            dockableControlPane4.Size = new System.Drawing.Size(285, 240);
            dockableControlPane4.Text = "Versions";
            dockableControlPane4.TextTab = "Versions";
            dockableControlPane5.Control = this.m_paneCodes;
            dockableControlPane5.Key = "Codes";
            dockableControlPane5.OriginalControlBounds = new System.Drawing.Rectangle(128, 128, 316, 288);
            dockableControlPane5.Size = new System.Drawing.Size(285, 240);
            dockableControlPane5.Text = "Fielded Data";
            dockableControlPane5.TextTab = "Fielded";
            dockableControlPane5.ToolTipTab = "";
            dockableControlPane6.Control = this.m_paneObjectionProperties;
            dockableControlPane6.Key = "ObjectionProperties";
            dockableControlPane6.OriginalControlBounds = new System.Drawing.Rectangle(216, 8, 79, 98);
            dockableControlPane6.Size = new System.Drawing.Size(100, 100);
            dockableControlPane6.Text = "Objection Props";
            dockableControlPane6.TextTab = "Objection Props";
            dockableControlPane6.ToolTipTab = "";
            dockableControlPane7.Control = this.m_paneHelp;
            dockableControlPane7.Key = "Help";
            dockableControlPane7.OriginalControlBounds = new System.Drawing.Rectangle(92, 76, 140, 44);
            dockableControlPane7.Size = new System.Drawing.Size(285, 240);
            dockableControlPane7.Text = "Help";
            dockableControlPane7.TextTab = "Help";
            dockAreaPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane1,
            dockableControlPane2,
            dockableControlPane3,
            dockableControlPane4,
            dockableControlPane5,
            dockableControlPane6,
            dockableControlPane7});
            dockAreaPane1.Size = new System.Drawing.Size(454, 915);
            dockAreaPane2.DockedBefore = new System.Guid("86f34a60-f2d5-497f-bc73-c4091785de8e");
            dockableControlPane8.Control = this.m_paneBinders;
            dockableControlPane8.Key = "Binders";
            dockableControlPane8.OriginalControlBounds = new System.Drawing.Rectangle(8, 8, 140, 44);
            dockableControlPane8.Size = new System.Drawing.Size(301, 258);
            dockableControlPane8.Text = "Binder Tree";
            dockableControlPane8.TextTab = "Binders";
            dockableGroupPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup;
            dockableControlPane9.Control = this.m_paneMedia;
            dockableControlPane9.Key = "Media";
            dockableControlPane9.OriginalControlBounds = new System.Drawing.Rectangle(8, 63, 140, 44);
            dockableControlPane9.Size = new System.Drawing.Size(163, 240);
            dockableControlPane9.Text = "Media Tree";
            dockableControlPane9.TextTab = "Media";
            dockableControlPane10.Control = this.m_paneFiltered;
            dockableControlPane10.Key = "FilteredTree";
            dockableControlPane10.OriginalControlBounds = new System.Drawing.Rectangle(36, 64, 92, 48);
            dockableControlPane10.Size = new System.Drawing.Size(163, 240);
            dockableControlPane10.Text = "Filtered Tree";
            dockableControlPane10.TextTab = "Filtered";
            dockableGroupPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane9,
            dockableControlPane10});
            dockableGroupPane1.Size = new System.Drawing.Size(301, 517);
            dockAreaPane2.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane8,
            dockableGroupPane1});
            dockAreaPane2.Size = new System.Drawing.Size(301, 915);
            dockAreaPane3.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup;
            dockAreaPane3.DockedBefore = new System.Guid("de049042-f47f-4c9f-b0ee-2eb5df5a37d8");
            dockableControlPane11.Control = this.m_paneObjections;
            dockableControlPane11.Key = "Objections";
            dockableControlPane11.OriginalControlBounds = new System.Drawing.Rectangle(90, 12, 226, 230);
            dockableControlPane11.Size = new System.Drawing.Size(100, 119);
            dockableControlPane11.Text = "Objections";
            dockableControlPane11.TextTab = "Objections";
            dockableControlPane12.Control = this.m_paneViewer;
            dockableControlPane12.Key = "Viewer";
            dockableControlPane12.OriginalControlBounds = new System.Drawing.Rectangle(184, 96, 140, 44);
            dockableControlPane12.Size = new System.Drawing.Size(142, 122);
            dockableControlPane12.Text = "Media Viewer";
            dockableControlPane12.TextTab = "Viewer";
            dockableControlPane13.Control = this.m_paneScripts;
            dockableControlPane13.Key = "Scripts";
            dockableControlPane13.OriginalControlBounds = new System.Drawing.Rectangle(156, 44, 140, 68);
            dockableControlPane13.Size = new System.Drawing.Size(142, 122);
            dockableControlPane13.Text = "Script Builder";
            dockableControlPane13.TextTab = "Scripts";
            dockableControlPane14.Control = this.m_paneTranscripts;
            dockableControlPane14.Key = "Transcripts";
            dockableControlPane14.OriginalControlBounds = new System.Drawing.Rectangle(32, 64, 140, 44);
            dockableControlPane14.Size = new System.Drawing.Size(142, 122);
            dockableControlPane14.Text = "Transcripts";
            dockableControlPane14.TextTab = "Transcripts";
            dockableControlPane15.Control = this.m_paneSource;
            dockableControlPane15.Key = "Source";
            dockableControlPane15.OriginalControlBounds = new System.Drawing.Rectangle(160, 164, 140, 44);
            dockableControlPane15.Size = new System.Drawing.Size(142, 122);
            dockableControlPane15.Text = "Source Explorer";
            dockableControlPane15.TextTab = "Source";
            dockableControlPane16.Control = this.m_paneResults;
            dockableControlPane16.Key = "Results";
            dockableControlPane16.OriginalControlBounds = new System.Drawing.Rectangle(132, 48, 32, 44);
            dockableControlPane16.Size = new System.Drawing.Size(163, 240);
            dockableControlPane16.Text = "Search Results";
            dockableControlPane16.TextTab = "Results";
            dockableControlPane17.Control = this.m_paneScriptReview;
            dockableControlPane17.Key = "ScriptReview";
            dockableControlPane17.OriginalControlBounds = new System.Drawing.Rectangle(-41, 28, 208, 90);
            dockableControlPane17.Size = new System.Drawing.Size(100, 100);
            dockableControlPane17.Text = "Script Review";
            dockableControlPane17.TextTab = "Script Review";
            dockableControlPane18.Control = this.m_paneErrors;
            dockableControlPane18.Key = "Errors";
            dockableControlPane18.OriginalControlBounds = new System.Drawing.Rectangle(8, 118, 140, 44);
            dockableControlPane18.Size = new System.Drawing.Size(285, 240);
            dockableControlPane18.Text = "Error Messages";
            dockableControlPane18.TextTab = "Errors";
            dockableControlPane19.Control = this.m_paneDiagnostics;
            dockableControlPane19.Key = "Diagnostics";
            dockableControlPane19.OriginalControlBounds = new System.Drawing.Rectangle(8, 173, 140, 44);
            dockableControlPane19.Size = new System.Drawing.Size(285, 240);
            dockableControlPane19.Text = "Diagnostic Messages";
            dockableControlPane19.TextTab = "Diagnostics";
            dockAreaPane3.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane11,
            dockableControlPane12,
            dockableControlPane13,
            dockableControlPane14,
            dockableControlPane15,
            dockableControlPane16,
            dockableControlPane17,
            dockableControlPane18,
            dockableControlPane19});
            dockAreaPane3.Size = new System.Drawing.Size(1001, 690);
            dockAreaPane4.DockedBefore = new System.Guid("202de6cb-040e-4107-bc73-3b1865ce0cfd");
            dockAreaPane4.FloatingLocation = new System.Drawing.Point(485, 156);
            dockAreaPane4.Size = new System.Drawing.Size(100, 100);
            dockAreaPane5.DockedBefore = new System.Guid("2733a411-3799-4537-acec-6b7203c51f83");
            dockAreaPane5.FloatingLocation = new System.Drawing.Point(1518, 519);
            dockAreaPane5.Size = new System.Drawing.Size(1206, 158);
            dockAreaPane6.FloatingLocation = new System.Drawing.Point(864, 482);
            dockAreaPane6.Size = new System.Drawing.Size(1032, 403);
            this.m_ctrlUltraDockManager.DockAreas.AddRange(new Infragistics.Win.UltraWinDock.DockAreaPane[] {
            dockAreaPane1,
            dockAreaPane2,
            dockAreaPane3,
            dockAreaPane4,
            dockAreaPane5,
            dockAreaPane6});
            this.m_ctrlUltraDockManager.DragWindowStyle = Infragistics.Win.UltraWinDock.DragWindowStyle.LayeredWindowWithIndicators;
            this.m_ctrlUltraDockManager.HostControl = this;
            this.m_ctrlUltraDockManager.ShowPinButton = false;
            this.m_ctrlUltraDockManager.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.Office2003;
            this.m_ctrlUltraDockManager.AfterPaneButtonClick += new Infragistics.Win.UltraWinDock.PaneButtonEventHandler(this.OnUltraPaneButtonClick);
            this.m_ctrlUltraDockManager.PaneActivate += new Infragistics.Win.UltraWinDock.ControlPaneEventHandler(this.OnUltraPaneActivate);
            this.m_ctrlUltraDockManager.PaneDeactivate += new Infragistics.Win.UltraWinDock.ControlPaneEventHandler(this.OnUltraPaneDectivate);
            // 
            // _TmaxManagerFormUnpinnedTabAreaLeft
            // 
            this._TmaxManagerFormUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._TmaxManagerFormUnpinnedTabAreaLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TmaxManagerFormUnpinnedTabAreaLeft.Location = new System.Drawing.Point(0, 26);
            this._TmaxManagerFormUnpinnedTabAreaLeft.Name = "_TmaxManagerFormUnpinnedTabAreaLeft";
            this._TmaxManagerFormUnpinnedTabAreaLeft.Owner = this.m_ctrlUltraDockManager;
            this._TmaxManagerFormUnpinnedTabAreaLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._TmaxManagerFormUnpinnedTabAreaLeft.Size = new System.Drawing.Size(0, 915);
            this._TmaxManagerFormUnpinnedTabAreaLeft.TabIndex = 1;
            // 
            // _TmaxManagerFormUnpinnedTabAreaRight
            // 
            this._TmaxManagerFormUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._TmaxManagerFormUnpinnedTabAreaRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TmaxManagerFormUnpinnedTabAreaRight.Location = new System.Drawing.Point(1766, 26);
            this._TmaxManagerFormUnpinnedTabAreaRight.Name = "_TmaxManagerFormUnpinnedTabAreaRight";
            this._TmaxManagerFormUnpinnedTabAreaRight.Owner = this.m_ctrlUltraDockManager;
            this._TmaxManagerFormUnpinnedTabAreaRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._TmaxManagerFormUnpinnedTabAreaRight.Size = new System.Drawing.Size(0, 915);
            this._TmaxManagerFormUnpinnedTabAreaRight.TabIndex = 2;
            // 
            // _TmaxManagerFormUnpinnedTabAreaTop
            // 
            this._TmaxManagerFormUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._TmaxManagerFormUnpinnedTabAreaTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TmaxManagerFormUnpinnedTabAreaTop.Location = new System.Drawing.Point(0, 26);
            this._TmaxManagerFormUnpinnedTabAreaTop.Name = "_TmaxManagerFormUnpinnedTabAreaTop";
            this._TmaxManagerFormUnpinnedTabAreaTop.Owner = this.m_ctrlUltraDockManager;
            this._TmaxManagerFormUnpinnedTabAreaTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._TmaxManagerFormUnpinnedTabAreaTop.Size = new System.Drawing.Size(1766, 0);
            this._TmaxManagerFormUnpinnedTabAreaTop.TabIndex = 3;
            // 
            // _TmaxManagerFormUnpinnedTabAreaBottom
            // 
            this._TmaxManagerFormUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._TmaxManagerFormUnpinnedTabAreaBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TmaxManagerFormUnpinnedTabAreaBottom.Location = new System.Drawing.Point(0, 941);
            this._TmaxManagerFormUnpinnedTabAreaBottom.Name = "_TmaxManagerFormUnpinnedTabAreaBottom";
            this._TmaxManagerFormUnpinnedTabAreaBottom.Owner = this.m_ctrlUltraDockManager;
            this._TmaxManagerFormUnpinnedTabAreaBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._TmaxManagerFormUnpinnedTabAreaBottom.Size = new System.Drawing.Size(1766, 0);
            this._TmaxManagerFormUnpinnedTabAreaBottom.TabIndex = 4;
            // 
            // _TmaxManagerFormAutoHideControl
            // 
            this._TmaxManagerFormAutoHideControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TmaxManagerFormAutoHideControl.Location = new System.Drawing.Point(0, 0);
            this._TmaxManagerFormAutoHideControl.Name = "_TmaxManagerFormAutoHideControl";
            this._TmaxManagerFormAutoHideControl.Owner = this.m_ctrlUltraDockManager;
            this._TmaxManagerFormAutoHideControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._TmaxManagerFormAutoHideControl.Size = new System.Drawing.Size(0, 0);
            this._TmaxManagerFormAutoHideControl.TabIndex = 5;
            // 
            // m_ctrlSmallImages
            // 
            this.m_ctrlSmallImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ctrlSmallImages.ImageStream")));
            this.m_ctrlSmallImages.TransparentColor = System.Drawing.Color.Magenta;
            this.m_ctrlSmallImages.Images.SetKeyName(0, "");
            this.m_ctrlSmallImages.Images.SetKeyName(1, "");
            this.m_ctrlSmallImages.Images.SetKeyName(2, "");
            this.m_ctrlSmallImages.Images.SetKeyName(3, "");
            this.m_ctrlSmallImages.Images.SetKeyName(4, "");
            this.m_ctrlSmallImages.Images.SetKeyName(5, "");
            this.m_ctrlSmallImages.Images.SetKeyName(6, "");
            this.m_ctrlSmallImages.Images.SetKeyName(7, "");
            this.m_ctrlSmallImages.Images.SetKeyName(8, "");
            this.m_ctrlSmallImages.Images.SetKeyName(9, "");
            this.m_ctrlSmallImages.Images.SetKeyName(10, "");
            this.m_ctrlSmallImages.Images.SetKeyName(11, "");
            this.m_ctrlSmallImages.Images.SetKeyName(12, "");
            this.m_ctrlSmallImages.Images.SetKeyName(13, "");
            this.m_ctrlSmallImages.Images.SetKeyName(14, "");
            this.m_ctrlSmallImages.Images.SetKeyName(15, "");
            this.m_ctrlSmallImages.Images.SetKeyName(16, "");
            this.m_ctrlSmallImages.Images.SetKeyName(17, "");
            this.m_ctrlSmallImages.Images.SetKeyName(18, "");
            this.m_ctrlSmallImages.Images.SetKeyName(19, "");
            this.m_ctrlSmallImages.Images.SetKeyName(20, "");
            this.m_ctrlSmallImages.Images.SetKeyName(21, "");
            this.m_ctrlSmallImages.Images.SetKeyName(22, "");
            this.m_ctrlSmallImages.Images.SetKeyName(23, "");
            this.m_ctrlSmallImages.Images.SetKeyName(24, "");
            this.m_ctrlSmallImages.Images.SetKeyName(25, "");
            this.m_ctrlSmallImages.Images.SetKeyName(26, "");
            this.m_ctrlSmallImages.Images.SetKeyName(27, "");
            this.m_ctrlSmallImages.Images.SetKeyName(28, "");
            this.m_ctrlSmallImages.Images.SetKeyName(29, "");
            this.m_ctrlSmallImages.Images.SetKeyName(30, "");
            this.m_ctrlSmallImages.Images.SetKeyName(31, "");
            this.m_ctrlSmallImages.Images.SetKeyName(32, "");
            this.m_ctrlSmallImages.Images.SetKeyName(33, "");
            this.m_ctrlSmallImages.Images.SetKeyName(34, "");
            this.m_ctrlSmallImages.Images.SetKeyName(35, "");
            this.m_ctrlSmallImages.Images.SetKeyName(36, "");
            this.m_ctrlSmallImages.Images.SetKeyName(37, "");
            this.m_ctrlSmallImages.Images.SetKeyName(38, "");
            this.m_ctrlSmallImages.Images.SetKeyName(39, "");
            this.m_ctrlSmallImages.Images.SetKeyName(40, "");
            this.m_ctrlSmallImages.Images.SetKeyName(41, "");
            this.m_ctrlSmallImages.Images.SetKeyName(42, "");
            this.m_ctrlSmallImages.Images.SetKeyName(43, "trim_database.bmp");
            this.m_ctrlSmallImages.Images.SetKeyName(44, "objection_import.bmp");
            this.m_ctrlSmallImages.Images.SetKeyName(45, "objection_export.bmp");
            this.m_ctrlSmallImages.Images.SetKeyName(46, "compact_database.bmp");
            // 
            // _TmaxManagerForm_Toolbars_Dock_Area_Top
            // 
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.Name = "_TmaxManagerForm_Toolbars_Dock_Area_Top";
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1766, 26);
            this._TmaxManagerForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.m_ctrlUltraToolbarManager;
            // 
            // m_ctrlUltraToolbarManager
            // 
            appearance3.AlphaLevel = ((short)(211));
            this.m_ctrlUltraToolbarManager.Appearance = appearance3;
            this.m_ctrlUltraToolbarManager.DesignerFlags = 1;
            this.m_ctrlUltraToolbarManager.DockWithinContainer = this;
            this.m_ctrlUltraToolbarManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.m_ctrlUltraToolbarManager.ImageListSmall = this.m_ctrlSmallImages;
            this.m_ctrlUltraToolbarManager.ShowFullMenusDelay = 500;
            this.m_ctrlUltraToolbarManager.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2003;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.IsMainMenuBar = true;
            labelTool1.InstanceProps.Width = 137;
            labelTool2.InstanceProps.Width = 47;
            textBoxTool1.InstanceProps.Width = 216;
            labelTool3.InstanceProps.Width = 24;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            popupMenuTool1,
            popupMenuTool2,
            popupMenuTool3,
            popupMenuTool4,
            popupMenuTool5,
            labelTool1,
            labelTool2,
            textBoxTool1,
            labelTool3});
            ultraToolbar1.Settings.FillEntireRow = Infragistics.Win.DefaultableBoolean.True;
            ultraToolbar1.Text = "Main Menu";
            this.m_ctrlUltraToolbarManager.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            popupMenuTool6.Settings.IsSideStripVisible = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.WhiteSmoke;
            appearance4.BackColor2 = System.Drawing.Color.Navy;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance4.FontData.ItalicAsString = "True";
            appearance4.FontData.Name = "Microsoft Sans Serif";
            appearance4.FontData.SizeInPoints = 16F;
            appearance4.TextVAlignAsString = "Middle";
            popupMenuTool6.Settings.SideStripAppearance = appearance4;
            popupMenuTool6.Settings.SideStripText = "Trialmax";
            popupMenuTool6.Settings.SideStripWidth = 24;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            popupMenuTool6.Settings.ToolAppearance = appearance5;
            popupMenuTool6.SharedPropsInternal.Caption = "&File";
            popupMenuTool6.SharedPropsInternal.Category = "File";
            buttonTool4.InstanceProps.IsFirstInGroup = true;
            buttonTool5.InstanceProps.IsFirstInGroup = true;
            popupMenuTool7.InstanceProps.IsFirstInGroup = true;
            buttonTool7.InstanceProps.IsFirstInGroup = true;
            buttonTool12.InstanceProps.IsFirstInGroup = true;
            popupMenuTool6.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            buttonTool2,
            buttonTool3,
            buttonTool4,
            buttonTool5,
            buttonTool6,
            popupMenuTool7,
            popupMenuTool8,
            buttonTool7,
            buttonTool8,
            buttonTool9,
            buttonTool10,
            buttonTool11,
            buttonTool12});
            appearance6.Image = 0;
            buttonTool13.SharedPropsInternal.AppearancesSmall.Appearance = appearance6;
            buttonTool13.SharedPropsInternal.Caption = "&New ...";
            buttonTool13.SharedPropsInternal.Category = "File";
            buttonTool13.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            appearance7.Image = 1;
            buttonTool14.SharedPropsInternal.AppearancesSmall.Appearance = appearance7;
            buttonTool14.SharedPropsInternal.Caption = "&Open ...";
            buttonTool14.SharedPropsInternal.Category = "File";
            buttonTool14.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            appearance8.Image = 4;
            buttonTool15.SharedPropsInternal.AppearancesSmall.Appearance = appearance8;
            buttonTool15.SharedPropsInternal.Caption = "&Close ...";
            buttonTool15.SharedPropsInternal.Category = "File";
            appearance9.Image = 5;
            buttonTool16.SharedPropsInternal.AppearancesSmall.Appearance = appearance9;
            buttonTool16.SharedPropsInternal.Caption = "E&xit";
            buttonTool16.SharedPropsInternal.Category = "File";
            buttonTool16.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            popupMenuTool9.Settings.ToolAppearance = appearance10;
            popupMenuTool9.SharedPropsInternal.Caption = "&View";
            popupMenuTool9.SharedPropsInternal.Category = "View";
            stateButtonTool1.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool2.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool3.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool4.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool5.InstanceProps.IsFirstInGroup = true;
            stateButtonTool5.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool6.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool7.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool8.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool9.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool10.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool11.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool12.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool13.InstanceProps.IsFirstInGroup = true;
            stateButtonTool13.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool14.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool15.InstanceProps.IsFirstInGroup = true;
            stateButtonTool15.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            buttonTool18.InstanceProps.IsFirstInGroup = true;
            buttonTool19.InstanceProps.IsFirstInGroup = true;
            stateButtonTool16.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            popupMenuTool9.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            stateButtonTool1,
            stateButtonTool2,
            stateButtonTool3,
            stateButtonTool4,
            stateButtonTool5,
            stateButtonTool6,
            stateButtonTool7,
            stateButtonTool8,
            stateButtonTool39,
            stateButtonTool9,
            stateButtonTool10,
            stateButtonTool11,
            stateButtonTool12,
            stateButtonTool13,
            stateButtonTool14,
            stateButtonTool15,
            popupMenuTool10,
            buttonTool17,
            buttonTool18,
            buttonTool19,
            stateButtonTool16});
            appearance11.Image = 6;
            buttonTool20.SharedPropsInternal.AppearancesSmall.Appearance = appearance11;
            buttonTool20.SharedPropsInternal.Caption = "Show &All";
            buttonTool20.SharedPropsInternal.Category = "View";
            appearance12.BackColor = System.Drawing.Color.Transparent;
            popupMenuTool11.Settings.ToolAppearance = appearance12;
            popupMenuTool11.SharedPropsInternal.Caption = "&Help";
            popupMenuTool11.SharedPropsInternal.Category = "Help";
            stateButtonTool17.InstanceProps.IsFirstInGroup = true;
            buttonTool25.InstanceProps.IsFirstInGroup = true;
            popupMenuTool11.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            stateButtonTool17,
            buttonTool21,
            buttonTool22,
            buttonTool23,
            buttonTool24,
            buttonTool25,
            buttonTool26});
            appearance13.Image = 3;
            buttonTool27.SharedPropsInternal.AppearancesSmall.Appearance = appearance13;
            buttonTool27.SharedPropsInternal.Caption = "&About ...";
            buttonTool27.SharedPropsInternal.Category = "Help";
            stateButtonTool18.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool18.SharedPropsInternal.Caption = "Source &Explorer";
            stateButtonTool18.SharedPropsInternal.Category = "View";
            stateButtonTool19.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool19.SharedPropsInternal.Caption = "&Media Tree";
            stateButtonTool19.SharedPropsInternal.Category = "View";
            stateButtonTool20.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool20.SharedPropsInternal.Caption = "&Binders";
            stateButtonTool20.SharedPropsInternal.Category = "View";
            stateButtonTool21.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool21.SharedPropsInternal.Caption = "Media &Viewer";
            stateButtonTool21.SharedPropsInternal.Category = "View";
            stateButtonTool21.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F8;
            stateButtonTool22.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool22.SharedPropsInternal.Caption = "&Properties";
            stateButtonTool22.SharedPropsInternal.Category = "View";
            stateButtonTool22.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F4;
            stateButtonTool23.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool23.SharedPropsInternal.Caption = "&Script Builder";
            stateButtonTool23.SharedPropsInternal.Category = "View";
            stateButtonTool23.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F6;
            stateButtonTool24.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool24.SharedPropsInternal.Caption = "Tra&nscripts";
            stateButtonTool24.SharedPropsInternal.Category = "View";
            stateButtonTool25.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool25.SharedPropsInternal.Caption = "&Tuner";
            stateButtonTool25.SharedPropsInternal.Category = "View";
            stateButtonTool25.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F7;
            stateButtonTool26.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool26.SharedPropsInternal.Caption = "Sear&ch Results";
            stateButtonTool26.SharedPropsInternal.Category = "View";
            popupMenuTool12.SharedPropsInternal.Caption = "Others";
            popupMenuTool12.SharedPropsInternal.Category = "View";
            stateButtonTool27.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool28.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            popupMenuTool12.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            stateButtonTool27,
            stateButtonTool28});
            stateButtonTool29.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool29.SharedPropsInternal.Caption = "Error Messages";
            stateButtonTool29.SharedPropsInternal.Category = "View";
            stateButtonTool30.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool30.SharedPropsInternal.Caption = "Diagnostics";
            stateButtonTool30.SharedPropsInternal.Category = "View";
            appearance14.Image = 2;
            stateButtonTool31.SharedPropsInternal.AppearancesSmall.Appearance = appearance14;
            stateButtonTool31.SharedPropsInternal.Caption = "&Contents";
            stateButtonTool31.SharedPropsInternal.Category = "Help";
            stateButtonTool31.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F1;
            stateButtonTool32.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool32.SharedPropsInternal.Caption = "Version &Information";
            stateButtonTool32.SharedPropsInternal.Category = "View";
            appearance15.Image = 7;
            buttonTool28.SharedPropsInternal.AppearancesSmall.Appearance = appearance15;
            buttonTool28.SharedPropsInternal.Caption = "Recent1";
            buttonTool28.SharedPropsInternal.Category = "File";
            buttonTool28.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            buttonTool28.SharedPropsInternal.Visible = false;
            buttonTool29.SharedPropsInternal.Caption = "Recent2";
            buttonTool29.SharedPropsInternal.Category = "File";
            buttonTool29.SharedPropsInternal.Visible = false;
            buttonTool30.SharedPropsInternal.Caption = "Recent3";
            buttonTool30.SharedPropsInternal.Category = "File";
            buttonTool30.SharedPropsInternal.Visible = false;
            buttonTool31.SharedPropsInternal.Caption = "Recent4";
            buttonTool31.SharedPropsInternal.Category = "File";
            buttonTool31.SharedPropsInternal.Visible = false;
            buttonTool32.SharedPropsInternal.Caption = "Recent5";
            buttonTool32.SharedPropsInternal.Category = "File";
            buttonTool32.SharedPropsInternal.Visible = false;
            appearance16.Image = 8;
            buttonTool33.SharedPropsInternal.AppearancesSmall.Appearance = appearance16;
            buttonTool33.SharedPropsInternal.Caption = "Save Screen Layout ...";
            buttonTool33.SharedPropsInternal.Category = "File";
            appearance17.Image = 9;
            buttonTool34.SharedPropsInternal.AppearancesSmall.Appearance = appearance17;
            buttonTool34.SharedPropsInternal.Caption = "Load Screen Layout ...";
            buttonTool34.SharedPropsInternal.Category = "File";
            popupMenuTool13.SharedPropsInternal.Caption = "&Tools";
            popupMenuTool13.SharedPropsInternal.Category = "Tools";
            buttonTool36.InstanceProps.IsFirstInGroup = true;
            buttonTool38.InstanceProps.IsFirstInGroup = true;
            buttonTool41.InstanceProps.IsFirstInGroup = true;
            buttonTool99.InstanceProps.IsFirstInGroup = true;
            popupMenuTool13.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool35,
            buttonTool36,
            buttonTool37,
            buttonTool98,
            buttonTool38,
            buttonTool39,
            buttonTool40,
            buttonTool41,
            buttonTool99});
            appearance18.Image = 10;
            buttonTool42.SharedPropsInternal.AppearancesSmall.Appearance = appearance18;
            buttonTool42.SharedPropsInternal.Caption = "&Presentation Options ...";
            buttonTool42.SharedPropsInternal.Category = "Tools";
            appearance19.BackColorDisabled = System.Drawing.SystemColors.Menu;
            textBoxTool2.EditAppearance = appearance19;
            textBoxTool2.SharedPropsInternal.Caption = "GoTo";
            textBoxTool2.SharedPropsInternal.ShowInCustomizer = false;
            textBoxTool2.SharedPropsInternal.Spring = true;
            textBoxTool2.SharedPropsInternal.ToolTipText = "Enter Barcode";
            labelTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            labelTool5.SharedPropsInternal.Caption = "Go To:";
            labelTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            labelTool5.SharedPropsInternal.ShowInCustomizer = false;
            labelTool5.SharedPropsInternal.ToolTipText = "Go to record";
            labelTool6.SharedPropsInternal.Spring = true;
            appearance20.Image = 11;
            buttonTool43.SharedPropsInternal.AppearancesSmall.Appearance = appearance20;
            buttonTool43.SharedPropsInternal.Caption = "&Refresh Treatments";
            buttonTool43.SharedPropsInternal.Category = "Tools";
            buttonTool43.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            appearance21.Image = 12;
            buttonTool44.SharedPropsInternal.AppearancesSmall.Appearance = appearance21;
            buttonTool44.SharedPropsInternal.Caption = "&Validate Database ...";
            buttonTool44.SharedPropsInternal.Category = "Tools";
            appearance22.Image = 13;
            buttonTool45.SharedPropsInternal.AppearancesSmall.Appearance = appearance22;
            buttonTool45.SharedPropsInternal.Caption = "&Case Options ...";
            buttonTool45.SharedPropsInternal.Category = "Tools";
            appearance23.Image = 28;
            buttonTool46.SharedPropsInternal.AppearancesSmall.Appearance = appearance23;
            buttonTool46.SharedPropsInternal.Caption = "&Refresh All";
            buttonTool46.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F9;
            appearance24.Image = 17;
            buttonTool47.SharedPropsInternal.AppearancesSmall.Appearance = appearance24;
            buttonTool47.SharedPropsInternal.Caption = "&Print ...";
            buttonTool47.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            appearance25.Image = 15;
            buttonTool48.SharedPropsInternal.AppearancesSmall.Appearance = appearance25;
            buttonTool48.SharedPropsInternal.Caption = "Find &Transcript Text ...";
            buttonTool48.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            appearance26.Image = 16;
            buttonTool49.SharedPropsInternal.AppearancesSmall.Appearance = appearance26;
            buttonTool49.SharedPropsInternal.Caption = "Find &Next";
            buttonTool49.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F3;
            appearance27.Image = 18;
            popupMenuTool14.SharedPropsInternal.AppearancesSmall.Appearance = appearance27;
            popupMenuTool14.SharedPropsInternal.Caption = "&Import";
            buttonTool52.InstanceProps.IsFirstInGroup = true;
            buttonTool54.InstanceProps.IsFirstInGroup = true;
            buttonTool57.InstanceProps.IsFirstInGroup = true;
            buttonTool58.InstanceProps.IsFirstInGroup = true;
            popupMenuTool14.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool50,
            buttonTool51,
            buttonTool52,
            buttonTool53,
            buttonTool54,
            buttonTool55,
            buttonTool56,
            buttonTool57,
            buttonTool58,
            buttonTool59});
            appearance28.Image = 19;
            popupMenuTool15.SharedPropsInternal.AppearancesSmall.Appearance = appearance28;
            popupMenuTool15.SharedPropsInternal.Caption = "&Export";
            popupMenuTool15.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool60,
            buttonTool61,
            buttonTool62});
            popupMenuTool16.SharedPropsInternal.Caption = "&Edit";
            buttonTool65.InstanceProps.IsFirstInGroup = true;
            buttonTool67.InstanceProps.IsFirstInGroup = true;
            popupMenuTool16.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool63,
            buttonTool64,
            buttonTool65,
            buttonTool66,
            buttonTool67});
            appearance29.Image = 20;
            buttonTool68.SharedPropsInternal.AppearancesSmall.Appearance = appearance29;
            buttonTool68.SharedPropsInternal.Caption = "Barcode &Map ...";
            appearance30.Image = 20;
            buttonTool69.SharedPropsInternal.AppearancesSmall.Appearance = appearance30;
            buttonTool69.SharedPropsInternal.Caption = "&Barcode Map To Text File ...";
            appearance31.Image = 40;
            buttonTool70.SharedPropsInternal.AppearancesSmall.Appearance = appearance31;
            buttonTool70.SharedPropsInternal.Caption = "&Binder(s) From Text File(s) ...";
            appearance32.Image = 33;
            buttonTool71.SharedPropsInternal.AppearancesSmall.Appearance = appearance32;
            buttonTool71.SharedPropsInternal.Caption = "&Script(s) From Text File(s) ...";
            stateButtonTool33.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool33.SharedPropsInternal.Caption = "Lock Panes In Place";
            appearance33.Image = 23;
            buttonTool72.SharedPropsInternal.AppearancesSmall.Appearance = appearance33;
            buttonTool72.SharedPropsInternal.Caption = "&Manager Options ...";
            appearance34.Image = 24;
            buttonTool73.SharedPropsInternal.AppearancesSmall.Appearance = appearance34;
            buttonTool73.SharedPropsInternal.Caption = "&Load File ...";
            appearance35.Image = 25;
            buttonTool74.SharedPropsInternal.AppearancesSmall.Appearance = appearance35;
            buttonTool74.SharedPropsInternal.Caption = "TrialMax Presentation ...";
            buttonTool74.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlF5;
            appearance36.Image = 26;
            buttonTool75.SharedPropsInternal.AppearancesSmall.Appearance = appearance36;
            buttonTool75.SharedPropsInternal.Caption = "Presentation &Toolbars ...";
            buttonTool76.SharedPropsInternal.Caption = "Debug 1";
            buttonTool77.SharedPropsInternal.Caption = "Debug 2";
            popupMenuTool17.SharedPropsInternal.Caption = "Debug";
            popupMenuTool17.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool78,
            buttonTool79});
            appearance37.Image = 27;
            buttonTool80.SharedPropsInternal.AppearancesSmall.Appearance = appearance37;
            buttonTool80.SharedPropsInternal.Caption = "Activate &TrialMax ...";
            appearance38.Image = 14;
            buttonTool81.SharedPropsInternal.AppearancesSmall.Appearance = appearance38;
            buttonTool81.SharedPropsInternal.Caption = "Check For &Updates ...";
            appearance39.Image = 29;
            buttonTool82.SharedPropsInternal.AppearancesSmall.Appearance = appearance39;
            buttonTool82.SharedPropsInternal.Caption = "Contact &FTI ...";
            appearance40.Image = 30;
            buttonTool83.SharedPropsInternal.AppearancesSmall.Appearance = appearance40;
            buttonTool83.SharedPropsInternal.Caption = "User\'s &Manual ...";
            stateButtonTool34.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool34.SharedPropsInternal.Caption = "Fielded &Data";
            stateButtonTool34.SharedPropsInternal.Category = "View";
            stateButtonTool34.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F10;
            appearance41.Image = 31;
            buttonTool84.SharedPropsInternal.AppearancesSmall.Appearance = appearance41;
            buttonTool84.SharedPropsInternal.Caption = "Fielded Data From &Text File(s) ...";
            stateButtonTool35.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool35.SharedPropsInternal.Caption = "&Filtered Tree";
            appearance42.Image = 32;
            buttonTool85.SharedPropsInternal.AppearancesSmall.Appearance = appearance42;
            buttonTool85.SharedPropsInternal.Caption = "&Advanced Filter ...";
            buttonTool85.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.F12;
            appearance43.Image = 34;
            buttonTool86.SharedPropsInternal.AppearancesSmall.Appearance = appearance43;
            buttonTool86.SharedPropsInternal.Caption = "Script(s) From &XML File(s) ...";
            appearance44.Image = 35;
            buttonTool87.SharedPropsInternal.AppearancesSmall.Appearance = appearance44;
            buttonTool87.SharedPropsInternal.Caption = "TrialMax &Online ...";
            appearance45.Image = 36;
            buttonTool88.SharedPropsInternal.AppearancesSmall.Appearance = appearance45;
            buttonTool88.SharedPropsInternal.Caption = "&Fielded Data Definitions ...";
            appearance46.Image = 37;
            buttonTool89.SharedPropsInternal.AppearancesSmall.Appearance = appearance46;
            buttonTool89.SharedPropsInternal.Caption = "&Fielded Data Definitions ...";
            appearance47.Image = 38;
            buttonTool90.SharedPropsInternal.AppearancesSmall.Appearance = appearance47;
            buttonTool90.SharedPropsInternal.Caption = "&Fast Filter ...";
            buttonTool90.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlF12;
            appearance48.Image = 39;
            buttonTool91.SharedPropsInternal.AppearancesSmall.Appearance = appearance48;
            buttonTool91.SharedPropsInternal.Caption = "Fielded Data From &Database ...";
            appearance49.Image = 41;
            buttonTool92.SharedPropsInternal.AppearancesSmall.Appearance = appearance49;
            buttonTool92.SharedPropsInternal.Caption = "Bi&nder(s) From XML File(s) ...";
            appearance50.Image = 42;
            buttonTool93.SharedPropsInternal.AppearancesSmall.Appearance = appearance50;
            buttonTool93.SharedPropsInternal.Caption = "&Update Fielded Data ...";
            appearance51.Image = 43;
            buttonTool94.SharedPropsInternal.AppearancesSmall.Appearance = appearance51;
            buttonTool94.SharedPropsInternal.Caption = "Trim Database ...";
            stateButtonTool36.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool36.SharedPropsInternal.Caption = "Objections";
            stateButtonTool37.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool37.SharedPropsInternal.Caption = "Script Review";
            appearance52.Image = 44;
            buttonTool95.SharedPropsInternal.AppearancesSmall.Appearance = appearance52;
            buttonTool95.SharedPropsInternal.Caption = "&Objections  From Text File(s) ...";
            appearance53.Image = 45;
            buttonTool96.SharedPropsInternal.AppearancesSmall.Appearance = appearance53;
            buttonTool96.SharedPropsInternal.Caption = "&Objections  To Text File ...";
            stateButtonTool38.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark;
            stateButtonTool38.SharedPropsInternal.Caption = "Objection Properties";
            appearance54.Image = 46;
            buttonTool97.SharedPropsInternal.AppearancesSmall.Appearance = appearance54;
            buttonTool97.SharedPropsInternal.Caption = "Compact Database ...";
            appearance55.Image = 25;
            buttonTool100.SharedPropsInternal.AppearancesSmall.Appearance = appearance55;
            buttonTool100.SharedPropsInternal.Caption = "&Show Active Users ...";
            buttonTool100.SharedPropsInternal.Category = "Tools";
            stateButtonTool40.SharedPropsInternal.Caption = "Registration Server";
            stateButtonTool40.SharedPropsInternal.Category = "View";
            this.m_ctrlUltraToolbarManager.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            popupMenuTool6,
            buttonTool13,
            buttonTool14,
            buttonTool15,
            buttonTool16,
            popupMenuTool9,
            buttonTool20,
            popupMenuTool11,
            buttonTool27,
            stateButtonTool18,
            stateButtonTool19,
            stateButtonTool20,
            stateButtonTool21,
            stateButtonTool22,
            stateButtonTool23,
            stateButtonTool24,
            stateButtonTool25,
            stateButtonTool26,
            popupMenuTool12,
            stateButtonTool29,
            stateButtonTool30,
            stateButtonTool31,
            stateButtonTool32,
            buttonTool28,
            buttonTool29,
            buttonTool30,
            buttonTool31,
            buttonTool32,
            buttonTool33,
            buttonTool34,
            popupMenuTool13,
            buttonTool42,
            textBoxTool2,
            labelTool4,
            labelTool5,
            labelTool6,
            buttonTool43,
            buttonTool44,
            buttonTool45,
            buttonTool46,
            buttonTool47,
            buttonTool48,
            buttonTool49,
            popupMenuTool14,
            popupMenuTool15,
            popupMenuTool16,
            buttonTool68,
            buttonTool69,
            buttonTool70,
            buttonTool71,
            stateButtonTool33,
            buttonTool72,
            buttonTool73,
            buttonTool74,
            buttonTool75,
            buttonTool76,
            buttonTool77,
            popupMenuTool17,
            buttonTool80,
            buttonTool81,
            buttonTool82,
            buttonTool83,
            stateButtonTool34,
            buttonTool84,
            stateButtonTool35,
            buttonTool85,
            buttonTool86,
            buttonTool87,
            buttonTool88,
            buttonTool89,
            buttonTool90,
            buttonTool91,
            buttonTool92,
            buttonTool93,
            buttonTool94,
            stateButtonTool36,
            stateButtonTool37,
            buttonTool95,
            buttonTool96,
            stateButtonTool38,
            buttonTool97,
            buttonTool100,
            stateButtonTool40});
            this.m_ctrlUltraToolbarManager.BeforeToolbarListDropdown += new Infragistics.Win.UltraWinToolbars.BeforeToolbarListDropdownEventHandler(this.OnUltraBeforeToolbarListDropdown);
            this.m_ctrlUltraToolbarManager.BeforeToolDropdown += new Infragistics.Win.UltraWinToolbars.BeforeToolDropdownEventHandler(this.OnUltraToolPopup);
            this.m_ctrlUltraToolbarManager.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.OnUltraToolClick);
            this.m_ctrlUltraToolbarManager.ToolKeyDown += new Infragistics.Win.UltraWinToolbars.ToolKeyEventHandler(this.OnUltraToolKeyDown);
            // 
            // _TmaxManagerForm_Toolbars_Dock_Area_Bottom
            // 
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 941);
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.Name = "_TmaxManagerForm_Toolbars_Dock_Area_Bottom";
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1766, 0);
            this._TmaxManagerForm_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.m_ctrlUltraToolbarManager;
            // 
            // _TmaxManagerForm_Toolbars_Dock_Area_Left
            // 
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 26);
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.Name = "_TmaxManagerForm_Toolbars_Dock_Area_Left";
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 915);
            this._TmaxManagerForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.m_ctrlUltraToolbarManager;
            // 
            // _TmaxManagerForm_Toolbars_Dock_Area_Right
            // 
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1766, 26);
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.Name = "_TmaxManagerForm_Toolbars_Dock_Area_Right";
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 915);
            this._TmaxManagerForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.m_ctrlUltraToolbarManager;
            // 
            // m_ctrlMainFillPanel
            // 
            this.m_ctrlMainFillPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_ctrlMainFillPanel.Controls.Add(this.m_tmxView);
            this.m_ctrlMainFillPanel.Controls.Add(this.m_ctrlScreenCapture);
            this.m_ctrlMainFillPanel.Controls.Add(this.m_ctrlPresentation);
            this.m_ctrlMainFillPanel.Controls.Add(this.m_tmxPrint);
            this.m_ctrlMainFillPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_ctrlMainFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ctrlMainFillPanel.Location = new System.Drawing.Point(306, 721);
            this.m_ctrlMainFillPanel.Name = "m_ctrlMainFillPanel";
            this.m_ctrlMainFillPanel.Size = new System.Drawing.Size(1001, 220);
            this.m_ctrlMainFillPanel.TabIndex = 5;
            // 
            // m_tmxView
            // 
            this.m_tmxView.AxAutoSave = false;
            this.m_tmxView.AxError = ((short)(0));
            this.m_tmxView.BackColor = System.Drawing.Color.Silver;
            this.m_tmxView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tmxView.EnableToolbar = false;
            this.m_tmxView.IniFilename = "";
            this.m_tmxView.IniSection = "";
            this.m_tmxView.Location = new System.Drawing.Point(92, 8);
            this.m_tmxView.Name = "m_tmxView";
            this.m_tmxView.NavigatorPosition = -1;
            this.m_tmxView.NavigatorTotal = 0;
            this.m_tmxView.ShowToolbar = false;
            this.m_tmxView.Size = new System.Drawing.Size(48, 40);
            this.m_tmxView.TabIndex = 32;
            this.m_tmxView.TextEditorActive = false;
            this.m_tmxView.UseScreenRatio = false;
            this.m_tmxView.Visible = false;
            this.m_tmxView.ZapSourceFile = "";
            this.m_tmxView.TmxEvent += new FTI.Trialmax.ActiveX.TmxEventHandler(this.OnTmxViewEvent);
            // 
            // m_ctrlScreenCapture
            // 
            this.m_ctrlScreenCapture.Enabled = true;
            this.m_ctrlScreenCapture.Location = new System.Drawing.Point(158, 8);
            this.m_ctrlScreenCapture.Name = "m_ctrlScreenCapture";
            this.m_ctrlScreenCapture.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_ctrlScreenCapture.OcxState")));
            this.m_ctrlScreenCapture.Size = new System.Drawing.Size(199, 40);
            this.m_ctrlScreenCapture.TabIndex = 31;
            // 
            // m_ctrlPresentation
            // 
            this.m_ctrlPresentation.AppFolder = "";
            this.m_ctrlPresentation.AxAutoSave = false;
            this.m_ctrlPresentation.AxError = ((short)(0));
            this.m_ctrlPresentation.BackColor = System.Drawing.Color.Black;
            this.m_ctrlPresentation.Barcode = "";
            this.m_ctrlPresentation.BarcodeId = 0;
            this.m_ctrlPresentation.CaseFolder = "";
            this.m_ctrlPresentation.Command = FTI.Trialmax.ActiveX.TmxShareCommands.None;
            this.m_ctrlPresentation.DisplayOrder = 0;
            this.m_ctrlPresentation.EnableToolbar = true;
            this.m_ctrlPresentation.IniFilename = "";
            this.m_ctrlPresentation.IniSection = "";
            this.m_ctrlPresentation.LineNumber = ((short)(0));
            this.m_ctrlPresentation.Location = new System.Drawing.Point(8, 8);
            this.m_ctrlPresentation.Name = "m_ctrlPresentation";
            this.m_ctrlPresentation.NavigatorPosition = -1;
            this.m_ctrlPresentation.NavigatorTotal = 0;
            this.m_ctrlPresentation.PageNumber = 0;
            this.m_ctrlPresentation.PrimaryId = 0;
            this.m_ctrlPresentation.QuaternaryId = 0;
            this.m_ctrlPresentation.SecondaryId = 0;
            this.m_ctrlPresentation.ShowToolbar = false;
            this.m_ctrlPresentation.Size = new System.Drawing.Size(36, 40);
            this.m_ctrlPresentation.SourceFileName = "";
            this.m_ctrlPresentation.SourceFilePath = "";
            this.m_ctrlPresentation.TabIndex = 0;
            this.m_ctrlPresentation.TertiaryId = 0;
            this.m_ctrlPresentation.Visible = false;
            this.m_ctrlPresentation.TmxShareRequestEvent += new FTI.Trialmax.ActiveX.TmxShareEventHandler(this.OnPresentationRequest);
            // 
            // m_tmxPrint
            // 
            this.m_tmxPrint.Enabled = true;
            this.m_tmxPrint.Location = new System.Drawing.Point(377, 8);
            this.m_tmxPrint.Name = "m_tmxPrint";
            this.m_tmxPrint.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_tmxPrint.OcxState")));
            this.m_tmxPrint.Size = new System.Drawing.Size(594, 397);
            this.m_tmxPrint.TabIndex = 29;
            this.m_tmxPrint.Visible = false;
            // 
            // windowDockingArea6
            // 
            this.windowDockingArea6.Controls.Add(this.dockableWindow1);
            this.windowDockingArea6.Controls.Add(this.dockableWindow2);
            this.windowDockingArea6.Controls.Add(this.dockableWindow3);
            this.windowDockingArea6.Controls.Add(this.dockableWindow4);
            this.windowDockingArea6.Controls.Add(this.dockableWindow5);
            this.windowDockingArea6.Controls.Add(this.dockableWindow12);
            this.windowDockingArea6.Controls.Add(this.dockableWindow19);
            this.windowDockingArea6.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowDockingArea6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea6.Location = new System.Drawing.Point(1307, 26);
            this.windowDockingArea6.Name = "windowDockingArea6";
            this.windowDockingArea6.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea6.Size = new System.Drawing.Size(459, 915);
            this.windowDockingArea6.TabIndex = 38;
            // 
            // dockableWindow1
            // 
            this.dockableWindow1.Controls.Add(this.m_paneRegistration);
            this.dockableWindow1.Location = new System.Drawing.Point(7, 2);
            this.dockableWindow1.Name = "dockableWindow1";
            this.dockableWindow1.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow1.Size = new System.Drawing.Size(450, 891);
            this.dockableWindow1.TabIndex = 43;
            // 
            // dockableWindow2
            // 
            this.dockableWindow2.Controls.Add(this.m_paneTuner);
            this.dockableWindow2.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow2.Name = "dockableWindow2";
            this.dockableWindow2.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow2.Size = new System.Drawing.Size(276, 502);
            this.dockableWindow2.TabIndex = 44;
            // 
            // dockableWindow3
            // 
            this.dockableWindow3.Controls.Add(this.m_paneProperties);
            this.dockableWindow3.Location = new System.Drawing.Point(-10000, 0);
            this.dockableWindow3.Name = "dockableWindow3";
            this.dockableWindow3.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow3.Size = new System.Drawing.Size(0, 0);
            this.dockableWindow3.TabIndex = 45;
            // 
            // dockableWindow4
            // 
            this.dockableWindow4.Controls.Add(this.m_paneVersions);
            this.dockableWindow4.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow4.Name = "dockableWindow4";
            this.dockableWindow4.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow4.Size = new System.Drawing.Size(276, 502);
            this.dockableWindow4.TabIndex = 46;
            // 
            // dockableWindow5
            // 
            this.dockableWindow5.Controls.Add(this.m_paneCodes);
            this.dockableWindow5.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow5.Name = "dockableWindow5";
            this.dockableWindow5.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow5.Size = new System.Drawing.Size(276, 828);
            this.dockableWindow5.TabIndex = 47;
            // 
            // dockableWindow12
            // 
            this.dockableWindow12.Controls.Add(this.m_paneObjectionProperties);
            this.dockableWindow12.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow12.Name = "dockableWindow12";
            this.dockableWindow12.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow12.Size = new System.Drawing.Size(276, 493);
            this.dockableWindow12.TabIndex = 48;
            // 
            // dockableWindow19
            // 
            this.dockableWindow19.Controls.Add(this.m_paneHelp);
            this.dockableWindow19.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow19.Name = "dockableWindow19";
            this.dockableWindow19.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow19.Size = new System.Drawing.Size(450, 828);
            this.dockableWindow19.TabIndex = 49;
            // 
            // dockableWindow8
            // 
            this.dockableWindow8.Controls.Add(this.m_paneBinders);
            this.dockableWindow8.Location = new System.Drawing.Point(2, 2);
            this.dockableWindow8.Name = "dockableWindow8";
            this.dockableWindow8.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow8.Size = new System.Drawing.Size(297, 302);
            this.dockableWindow8.TabIndex = 50;
            // 
            // dockableWindow10
            // 
            this.dockableWindow10.Controls.Add(this.m_paneMedia);
            this.dockableWindow10.Location = new System.Drawing.Point(4, 311);
            this.dockableWindow10.Name = "dockableWindow10";
            this.dockableWindow10.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow10.Size = new System.Drawing.Size(293, 580);
            this.dockableWindow10.TabIndex = 51;
            // 
            // dockableWindow11
            // 
            this.dockableWindow11.Controls.Add(this.m_paneFiltered);
            this.dockableWindow11.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow11.Name = "dockableWindow11";
            this.dockableWindow11.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow11.Size = new System.Drawing.Size(297, 170);
            this.dockableWindow11.TabIndex = 52;
            // 
            // windowDockingArea2
            // 
            this.windowDockingArea2.Controls.Add(this.dockableWindow8);
            this.windowDockingArea2.Controls.Add(this.dockableWindow10);
            this.windowDockingArea2.Controls.Add(this.dockableWindow11);
            this.windowDockingArea2.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowDockingArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea2.Location = new System.Drawing.Point(0, 26);
            this.windowDockingArea2.Name = "windowDockingArea2";
            this.windowDockingArea2.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea2.Size = new System.Drawing.Size(306, 915);
            this.windowDockingArea2.TabIndex = 11;
            // 
            // dockableWindow14
            // 
            this.dockableWindow14.Controls.Add(this.m_paneObjections);
            this.dockableWindow14.Location = new System.Drawing.Point(2, 2);
            this.dockableWindow14.Name = "dockableWindow14";
            this.dockableWindow14.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow14.Size = new System.Drawing.Size(997, 666);
            this.dockableWindow14.TabIndex = 53;
            // 
            // dockableWindow15
            // 
            this.dockableWindow15.Controls.Add(this.m_paneViewer);
            this.dockableWindow15.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow15.Name = "dockableWindow15";
            this.dockableWindow15.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow15.Size = new System.Drawing.Size(636, 346);
            this.dockableWindow15.TabIndex = 54;
            // 
            // dockableWindow16
            // 
            this.dockableWindow16.Controls.Add(this.m_paneScripts);
            this.dockableWindow16.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow16.Name = "dockableWindow16";
            this.dockableWindow16.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow16.Size = new System.Drawing.Size(636, 346);
            this.dockableWindow16.TabIndex = 55;
            // 
            // dockableWindow17
            // 
            this.dockableWindow17.Controls.Add(this.m_paneTranscripts);
            this.dockableWindow17.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow17.Name = "dockableWindow17";
            this.dockableWindow17.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow17.Size = new System.Drawing.Size(1036, 342);
            this.dockableWindow17.TabIndex = 56;
            // 
            // dockableWindow18
            // 
            this.dockableWindow18.Controls.Add(this.m_paneSource);
            this.dockableWindow18.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow18.Name = "dockableWindow18";
            this.dockableWindow18.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow18.Size = new System.Drawing.Size(976, 281);
            this.dockableWindow18.TabIndex = 57;
            // 
            // dockableWindow6
            // 
            this.dockableWindow6.Controls.Add(this.m_paneResults);
            this.dockableWindow6.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow6.Name = "dockableWindow6";
            this.dockableWindow6.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow6.Size = new System.Drawing.Size(638, 281);
            this.dockableWindow6.TabIndex = 58;
            // 
            // dockableWindow7
            // 
            this.dockableWindow7.Controls.Add(this.m_paneScriptReview);
            this.dockableWindow7.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow7.Name = "dockableWindow7";
            this.dockableWindow7.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow7.Size = new System.Drawing.Size(636, 346);
            this.dockableWindow7.TabIndex = 59;
            // 
            // dockableWindow9
            // 
            this.dockableWindow9.Controls.Add(this.m_paneErrors);
            this.dockableWindow9.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow9.Name = "dockableWindow9";
            this.dockableWindow9.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow9.Size = new System.Drawing.Size(976, 281);
            this.dockableWindow9.TabIndex = 60;
            // 
            // dockableWindow13
            // 
            this.dockableWindow13.Controls.Add(this.m_paneDiagnostics);
            this.dockableWindow13.Location = new System.Drawing.Point(-10000, 2);
            this.dockableWindow13.Name = "dockableWindow13";
            this.dockableWindow13.Owner = this.m_ctrlUltraDockManager;
            this.dockableWindow13.Size = new System.Drawing.Size(1036, 666);
            this.dockableWindow13.TabIndex = 61;
            // 
            // windowDockingArea1
            // 
            this.windowDockingArea1.Controls.Add(this.dockableWindow14);
            this.windowDockingArea1.Controls.Add(this.dockableWindow15);
            this.windowDockingArea1.Controls.Add(this.dockableWindow16);
            this.windowDockingArea1.Controls.Add(this.dockableWindow17);
            this.windowDockingArea1.Controls.Add(this.dockableWindow6);
            this.windowDockingArea1.Controls.Add(this.dockableWindow7);
            this.windowDockingArea1.Controls.Add(this.dockableWindow9);
            this.windowDockingArea1.Controls.Add(this.dockableWindow18);
            this.windowDockingArea1.Controls.Add(this.dockableWindow13);
            this.windowDockingArea1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowDockingArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea1.Location = new System.Drawing.Point(306, 26);
            this.windowDockingArea1.Name = "windowDockingArea1";
            this.windowDockingArea1.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea1.Size = new System.Drawing.Size(1001, 695);
            this.windowDockingArea1.TabIndex = 10;
            // 
            // windowDockingArea3
            // 
            this.windowDockingArea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowDockingArea3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea3.Location = new System.Drawing.Point(306, 401);
            this.windowDockingArea3.Name = "windowDockingArea3";
            this.windowDockingArea3.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea3.Size = new System.Drawing.Size(100, 100);
            this.windowDockingArea3.TabIndex = 43;
            // 
            // windowDockingArea5
            // 
            this.windowDockingArea5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowDockingArea5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea5.Location = new System.Drawing.Point(4, 4);
            this.windowDockingArea5.Name = "windowDockingArea5";
            this.windowDockingArea5.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea5.Size = new System.Drawing.Size(1206, 158);
            this.windowDockingArea5.TabIndex = 0;
            // 
            // windowDockingArea7
            // 
            this.windowDockingArea7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowDockingArea7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea7.Location = new System.Drawing.Point(4, 4);
            this.windowDockingArea7.Name = "windowDockingArea7";
            this.windowDockingArea7.Owner = this.m_ctrlUltraDockManager;
            this.windowDockingArea7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowDockingArea7.Size = new System.Drawing.Size(1032, 403);
            this.windowDockingArea7.TabIndex = 0;
            // 
            // TmaxManagerForm
            // 
            this.AccessibleName = "";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1766, 941);
            this.Controls.Add(this._TmaxManagerFormAutoHideControl);
            this.Controls.Add(this.m_ctrlMainFillPanel);
            this.Controls.Add(this._TmaxManagerFormUnpinnedTabAreaLeft);
            this.Controls.Add(this._TmaxManagerFormUnpinnedTabAreaTop);
            this.Controls.Add(this._TmaxManagerFormUnpinnedTabAreaBottom);
            this.Controls.Add(this._TmaxManagerFormUnpinnedTabAreaRight);
            this.Controls.Add(this.windowDockingArea1);
            this.Controls.Add(this.windowDockingArea2);
            this.Controls.Add(this.windowDockingArea6);
            this.Controls.Add(this._TmaxManagerForm_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._TmaxManagerForm_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._TmaxManagerForm_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this._TmaxManagerForm_Toolbars_Dock_Area_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TmaxManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTI Consulting - TrialMax Manager";
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlUltraDockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlUltraToolbarManager)).EndInit();
            this.m_ctrlMainFillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_ctrlScreenCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tmxPrint)).EndInit();
            this.windowDockingArea6.ResumeLayout(false);
            this.dockableWindow1.ResumeLayout(false);
            this.dockableWindow2.ResumeLayout(false);
            this.dockableWindow3.ResumeLayout(false);
            this.dockableWindow4.ResumeLayout(false);
            this.dockableWindow5.ResumeLayout(false);
            this.dockableWindow12.ResumeLayout(false);
            this.dockableWindow19.ResumeLayout(false);
            this.dockableWindow8.ResumeLayout(false);
            this.dockableWindow10.ResumeLayout(false);
            this.dockableWindow11.ResumeLayout(false);
            this.windowDockingArea2.ResumeLayout(false);
            this.dockableWindow14.ResumeLayout(false);
            this.dockableWindow15.ResumeLayout(false);
            this.dockableWindow16.ResumeLayout(false);
            this.dockableWindow17.ResumeLayout(false);
            this.dockableWindow18.ResumeLayout(false);
            this.dockableWindow6.ResumeLayout(false);
            this.dockableWindow7.ResumeLayout(false);
            this.dockableWindow9.ResumeLayout(false);
            this.dockableWindow13.ResumeLayout(false);
            this.windowDockingArea1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panes.CCodesPane m_paneCodes;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea2;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow14;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow15;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow16;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow17;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow18;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow8;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow9;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow10;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow11;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow12;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow13;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea6;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow1;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow2;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow3;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow4;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow5;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow6;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow7;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea1;
        private Panes.RegistrationPane m_paneRegistration;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea3;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow19;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea5;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea7;
    }
}