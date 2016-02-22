namespace $safeprojectname$
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

    public partial class AppForm : Form
    {
        private readonly ILog Logger;

        public AppForm(ILog logger)
        {
            Logger = logger;            
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Logger.Info("App started");
        }
    }
}
