
namespace PaintBox
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.모양ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.모양ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileMenuItem,
            this.openFileMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldColorMenuItem,
            this.entityColorMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.편집ToolStripMenuItem.Text = "색 변경";
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenuItem.Text = "저장";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileMenuItem.Text = "불러오기";
            // 
            // fieldColorMenuItem
            // 
            this.fieldColorMenuItem.Name = "fieldColorMenuItem";
            this.fieldColorMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fieldColorMenuItem.Text = "배경색 변경";
            // 
            // entityColorMenuItem
            // 
            this.entityColorMenuItem.Name = "entityColorMenuItem";
            this.entityColorMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entityColorMenuItem.Text = "엔티티색 변경";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 426);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // 모양ToolStripMenuItem
            // 
            this.모양ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleMenuItem,
            this.rectangleMenuItem,
            this.circleMenuItem,
            this.lineMenuItem});
            this.모양ToolStripMenuItem.Name = "모양ToolStripMenuItem";
            this.모양ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.모양ToolStripMenuItem.Text = "엔티티";
            // 
            // triangleMenuItem
            // 
            this.triangleMenuItem.Name = "triangleMenuItem";
            this.triangleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triangleMenuItem.Text = "삼각형";
            // 
            // rectangleMenuItem
            // 
            this.rectangleMenuItem.Name = "rectangleMenuItem";
            this.rectangleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangleMenuItem.Text = "사각형";
            // 
            // circleMenuItem
            // 
            this.circleMenuItem.Name = "circleMenuItem";
            this.circleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circleMenuItem.Text = "원";
            // 
            // lineMenuItem
            // 
            this.lineMenuItem.Name = "lineMenuItem";
            this.lineMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineMenuItem.Text = "직선";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "PictureBox";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entityColorMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem 모양ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineMenuItem;
    }
}

