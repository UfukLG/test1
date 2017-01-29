namespace SimpleProjectManager.Module.Controllers
{
    partial class TaskController2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "evet";
            this.simpleAction1.Category = "Menu";
            this.simpleAction1.ConfirmationMessage = "evet mi?";
            this.simpleAction1.Id = "evet";
            this.simpleAction1.TargetObjectType = typeof(SimpleProjectManager.Module.BusinessObjects.Planning.Project);
            this.simpleAction1.ToolTip = null;
            // 
            // TaskController2
            // 
            this.Actions.Add(this.simpleAction1);
            this.TargetObjectType = typeof(SimpleProjectManager.Module.BusinessObjects.Planning.Project);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
    }
}
