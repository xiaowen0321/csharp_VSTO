namespace PowerPointAlignCenter
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonHorizontalAlignMiddle = this.Factory.CreateRibbonButton();
            this.buttonVerticalAlignMiddle = this.Factory.CreateRibbonButton();
            this.buttonAlignMiddle = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonHorizontalAlignMiddle);
            this.group1.Items.Add(this.buttonVerticalAlignMiddle);
            this.group1.Items.Add(this.buttonAlignMiddle);
            this.group1.Label = "排列";
            this.group1.Name = "group1";
            // 
            // buttonHorizontalAlignMiddle
            // 
            this.buttonHorizontalAlignMiddle.Label = "水平居中";
            this.buttonHorizontalAlignMiddle.Name = "buttonHorizontalAlignMiddle";
            this.buttonHorizontalAlignMiddle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonAlignMiddle_Click);
            // 
            // buttonVerticalAlignMiddle
            // 
            this.buttonVerticalAlignMiddle.Label = "垂直居中";
            this.buttonVerticalAlignMiddle.Name = "buttonVerticalAlignMiddle";
            this.buttonVerticalAlignMiddle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonAlignMiddle_Click);
            // 
            // buttonAlignMiddle
            // 
            this.buttonAlignMiddle.Label = "完全居中";
            this.buttonAlignMiddle.Name = "buttonAlignMiddle";
            this.buttonAlignMiddle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonAlignMiddle_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonHorizontalAlignMiddle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonVerticalAlignMiddle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAlignMiddle;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
