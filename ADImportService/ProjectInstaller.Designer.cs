﻿namespace Kentico.ADImportService
{
    partial class ProjectInstaller
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
            this.ListenerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ListenerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ListenerServiceProcessInstaller
            // 
            this.ListenerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ListenerServiceProcessInstaller.Password = null;
            this.ListenerServiceProcessInstaller.Username = null;
            // 
            // ListenerServiceInstaller
            // 
            this.ListenerServiceInstaller.Description = "Kentico Active Directory Import Service";
            this.ListenerServiceInstaller.DisplayName = "Kentico AD Import Service";
            this.ListenerServiceInstaller.ServiceName = "KenticoADImportService";
            this.ListenerServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ListenerServiceProcessInstaller,
            this.ListenerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ListenerServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ListenerServiceInstaller;
    }
}