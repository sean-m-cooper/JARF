namespace JARF
{
    partial class frmDesigner
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlDBObjects = new System.Windows.Forms.TabControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.tabViews = new System.Windows.Forms.TabPage();
            this.lstViews = new System.Windows.Forms.ListBox();
            this.viewContainer = new System.Windows.Forms.SplitContainer();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.ctxTvTables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlDBObjects.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewContainer)).BeginInit();
            this.viewContainer.Panel1.SuspendLayout();
            this.viewContainer.SuspendLayout();
            this.ctxTvTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDBObjects
            // 
            this.tabControlDBObjects.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlDBObjects.Controls.Add(this.tabTables);
            this.tabControlDBObjects.Controls.Add(this.tabViews);
            this.tabControlDBObjects.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlDBObjects.ItemSize = new System.Drawing.Size(25, 100);
            this.tabControlDBObjects.Location = new System.Drawing.Point(12, 12);
            this.tabControlDBObjects.Multiline = true;
            this.tabControlDBObjects.Name = "tabControlDBObjects";
            this.tabControlDBObjects.SelectedIndex = 0;
            this.tabControlDBObjects.Size = new System.Drawing.Size(388, 399);
            this.tabControlDBObjects.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlDBObjects.TabIndex = 0;
            this.tabControlDBObjects.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlDBObjects_DrawItem);
            // 
            // tabTables
            // 
            this.tabTables.Controls.Add(this.lstTables);
            this.tabTables.Location = new System.Drawing.Point(4, 4);
            this.tabTables.Name = "tabTables";
            this.tabTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabTables.Size = new System.Drawing.Size(280, 391);
            this.tabTables.TabIndex = 0;
            this.tabTables.Text = "Tables";
            this.tabTables.UseVisualStyleBackColor = true;
            // 
            // lstTables
            // 
            this.lstTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(6, 6);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(182, 91);
            this.lstTables.TabIndex = 0;
            this.lstTables.DoubleClick += new System.EventHandler(this.lstTables_DoubleClick);
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.lstViews);
            this.tabViews.Location = new System.Drawing.Point(4, 4);
            this.tabViews.Name = "tabViews";
            this.tabViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabViews.Size = new System.Drawing.Size(280, 391);
            this.tabViews.TabIndex = 1;
            this.tabViews.Text = "Views";
            this.tabViews.UseVisualStyleBackColor = true;
            // 
            // lstViews
            // 
            this.lstViews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstViews.FormattingEnabled = true;
            this.lstViews.Location = new System.Drawing.Point(6, 6);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(182, 91);
            this.lstViews.TabIndex = 0;
            // 
            // viewContainer
            // 
            this.viewContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewContainer.Location = new System.Drawing.Point(406, 12);
            this.viewContainer.Name = "viewContainer";
            // 
            // viewContainer.Panel1
            // 
            this.viewContainer.Panel1.Controls.Add(this.tvTables);
            this.viewContainer.Size = new System.Drawing.Size(793, 395);
            this.viewContainer.SplitterDistance = 600;
            this.viewContainer.TabIndex = 1;
            // 
            // tvTables
            // 
            this.tvTables.CheckBoxes = true;
            this.tvTables.ContextMenuStrip = this.ctxTvTables;
            this.tvTables.Location = new System.Drawing.Point(4, 8);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(121, 97);
            this.tvTables.TabIndex = 0;
            this.tvTables.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvTables_AfterCheck);
            this.tvTables.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTables_NodeMouseClick);
            this.tvTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvTables_MouseClick);
            // 
            // ctxTvTables
            // 
            this.ctxTvTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMoveUp,
            this.tsmMoveDown,
            this.tsmRemove});
            this.ctxTvTables.Name = "ctxTvTables";
            this.ctxTvTables.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmMoveUp
            // 
            this.tsmMoveUp.Name = "tsmMoveUp";
            this.tsmMoveUp.Size = new System.Drawing.Size(180, 22);
            this.tsmMoveUp.Text = "Move Up";
            this.tsmMoveUp.Click += new System.EventHandler(this.tsmMoveUp_Click);
            // 
            // tsmMoveDown
            // 
            this.tsmMoveDown.Name = "tsmMoveDown";
            this.tsmMoveDown.Size = new System.Drawing.Size(180, 22);
            this.tsmMoveDown.Text = "Move Down";
            this.tsmMoveDown.Click += new System.EventHandler(this.tsmMoveDown_Click);
            // 
            // tsmRemove
            // 
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.tsmRemove.Size = new System.Drawing.Size(180, 22);
            this.tsmRemove.Text = "Remove";
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // frmDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 857);
            this.Controls.Add(this.viewContainer);
            this.Controls.Add(this.tabControlDBObjects);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "frmDesigner";
            this.Text = "frmDesigner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDesigner_FormClosed);
            this.Load += new System.EventHandler(this.frmDesigner_Load);
            this.Resize += new System.EventHandler(this.frmDesigner_Resize);
            this.tabControlDBObjects.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            this.tabViews.ResumeLayout(false);
            this.viewContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewContainer)).EndInit();
            this.viewContainer.ResumeLayout(false);
            this.ctxTvTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDBObjects;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.TabPage tabViews;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstViews;
        private System.Windows.Forms.SplitContainer viewContainer;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.ContextMenuStrip ctxTvTables;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveDown;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
    }
}