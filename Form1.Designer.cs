
namespace inlamningsuppgift2_L0002B_annkov_0
{
    partial class Form1
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
            this.name_l = new System.Windows.Forms.Label();
            this.lastName_l = new System.Windows.Forms.Label();
            this.id_l = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.buttons_layout = new System.Windows.Forms.TableLayoutPanel();
            this.verify_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.info_l = new System.Windows.Forms.Label();
            this.Instruction_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.result_l = new System.Windows.Forms.Label();
            this.resultatName_l = new System.Windows.Forms.Label();
            this.buttons_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_l
            // 
            this.name_l.AutoSize = true;
            this.name_l.Location = new System.Drawing.Point(12, 64);
            this.name_l.Name = "name_l";
            this.name_l.Size = new System.Drawing.Size(35, 13);
            this.name_l.TabIndex = 0;
            this.name_l.Text = "Namn";
            // 
            // lastName_l
            // 
            this.lastName_l.AutoSize = true;
            this.lastName_l.Location = new System.Drawing.Point(12, 113);
            this.lastName_l.Name = "lastName_l";
            this.lastName_l.Size = new System.Drawing.Size(55, 13);
            this.lastName_l.TabIndex = 1;
            this.lastName_l.Text = "Efternamn";
            // 
            // id_l
            // 
            this.id_l.AutoSize = true;
            this.id_l.Location = new System.Drawing.Point(12, 164);
            this.id_l.Name = "id_l";
            this.id_l.Size = new System.Drawing.Size(49, 13);
            this.id_l.TabIndex = 2;
            this.id_l.Text = "Personnr";
            // 
            // name_tb
            // 
            this.name_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_tb.Location = new System.Drawing.Point(14, 80);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(381, 20);
            this.name_tb.TabIndex = 4;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName_tb.Location = new System.Drawing.Point(14, 130);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(381, 20);
            this.lastName_tb.TabIndex = 5;
            // 
            // id_tb
            // 
            this.id_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id_tb.Location = new System.Drawing.Point(13, 181);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(382, 20);
            this.id_tb.TabIndex = 6;
            // 
            // buttons_layout
            // 
            this.buttons_layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons_layout.ColumnCount = 2;
            this.buttons_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_layout.Controls.Add(this.verify_button, 0, 0);
            this.buttons_layout.Controls.Add(this.clear_button, 1, 0);
            this.buttons_layout.Location = new System.Drawing.Point(15, 223);
            this.buttons_layout.Name = "buttons_layout";
            this.buttons_layout.RowCount = 1;
            this.buttons_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons_layout.Size = new System.Drawing.Size(380, 64);
            this.buttons_layout.TabIndex = 8;
            // 
            // verify_button
            // 
            this.verify_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify_button.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_button.ForeColor = System.Drawing.Color.AliceBlue;
            this.verify_button.Location = new System.Drawing.Point(3, 3);
            this.verify_button.Name = "verify_button";
            this.verify_button.Size = new System.Drawing.Size(175, 58);
            this.verify_button.TabIndex = 0;
            this.verify_button.Text = "Kontrollera";
            this.verify_button.UseVisualStyleBackColor = false;
            this.verify_button.Click += new System.EventHandler(this.verify_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.AliceBlue;
            this.clear_button.Location = new System.Drawing.Point(202, 3);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(175, 58);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Nollställa";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // info_l
            // 
            this.info_l.Location = new System.Drawing.Point(15, 353);
            this.info_l.Name = "info_l";
            this.info_l.Size = new System.Drawing.Size(376, 20);
            this.info_l.TabIndex = 9;
            // 
            // Instruction_l
            // 
            this.Instruction_l.AutoSize = true;
            this.Instruction_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction_l.Location = new System.Drawing.Point(11, 21);
            this.Instruction_l.Name = "Instruction_l";
            this.Instruction_l.Size = new System.Drawing.Size(192, 20);
            this.Instruction_l.TabIndex = 10;
            this.Instruction_l.Text = "Ange namn och personnr:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 12;
            // 
            // result_l
            // 
            this.result_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_l.Location = new System.Drawing.Point(15, 330);
            this.result_l.Name = "result_l";
            this.result_l.Size = new System.Drawing.Size(376, 121);
            this.result_l.TabIndex = 13;
            // 
            // resultatName_l
            // 
            this.resultatName_l.AutoSize = true;
            this.resultatName_l.Location = new System.Drawing.Point(15, 311);
            this.resultatName_l.Name = "resultatName_l";
            this.resultatName_l.Size = new System.Drawing.Size(49, 13);
            this.resultatName_l.TabIndex = 14;
            this.resultatName_l.Text = "Resultat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 460);
            this.Controls.Add(this.resultatName_l);
            this.Controls.Add(this.result_l);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instruction_l);
            this.Controls.Add(this.info_l);
            this.Controls.Add(this.buttons_layout);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_l);
            this.Controls.Add(this.lastName_l);
            this.Controls.Add(this.name_l);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Personnummerkontroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttons_layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_l;
        private System.Windows.Forms.Label lastName_l;
        private System.Windows.Forms.Label id_l;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TableLayoutPanel buttons_layout;
        private System.Windows.Forms.Button verify_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label info_l;
        private System.Windows.Forms.Label Instruction_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label result_l;
        private System.Windows.Forms.Label resultatName_l;
    }
}

