namespace mook_WifiScanner
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAP = new System.Windows.Forms.ListView();
            this.chSSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChanel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlgorithm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvAP
            // 
            this.lvAP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSSID,
            this.chQuality,
            this.chEnabled,
            this.chChanel,
            this.chAlgorithm,
            this.chAuth,
            this.chMAC});
            this.lvAP.FullRowSelect = true;
            this.lvAP.GridLines = true;
            this.lvAP.Location = new System.Drawing.Point(12, 12);
            this.lvAP.Name = "lvAP";
            this.lvAP.Size = new System.Drawing.Size(660, 440);
            this.lvAP.TabIndex = 4;
            this.lvAP.UseCompatibleStateImageBehavior = false;
            this.lvAP.View = System.Windows.Forms.View.Details;
            // 
            // chSSID
            // 
            this.chSSID.Text = "이름";
            this.chSSID.Width = 100;
            // 
            // chQuality
            // 
            this.chQuality.Text = "신호강도";
            // 
            // chEnabled
            // 
            this.chEnabled.Text = "암호화";
            // 
            // chChanel
            // 
            this.chChanel.Text = "채널";
            this.chChanel.Width = 58;
            // 
            // chAlgorithm
            // 
            this.chAlgorithm.Text = "암호방식";
            // 
            // chAuth
            // 
            this.chAuth.Text = "인증방식";
            this.chAuth.Width = 100;
            // 
            // chMAC
            // 
            this.chMAC.Text = "MAC";
            this.chMAC.Width = 174;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 468);
            this.Controls.Add(this.lvAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "무선네트워크 탐지프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAP;
        private System.Windows.Forms.ColumnHeader chSSID;
        private System.Windows.Forms.ColumnHeader chQuality;
        private System.Windows.Forms.ColumnHeader chEnabled;
        private System.Windows.Forms.ColumnHeader chChanel;
        private System.Windows.Forms.ColumnHeader chAlgorithm;
        private System.Windows.Forms.ColumnHeader chAuth;
        private System.Windows.Forms.ColumnHeader chMAC;
    }
}

