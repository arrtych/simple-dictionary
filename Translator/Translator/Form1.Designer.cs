namespace Translator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.translateWord = new System.Windows.Forms.TextBox();
            this.translateResult = new System.Windows.Forms.RichTextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dictionarySource = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select dictionary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word to translate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Translation restult :";
            // 
            // translateWord
            // 
            this.translateWord.Location = new System.Drawing.Point(218, 190);
            this.translateWord.Name = "translateWord";
            this.translateWord.Size = new System.Drawing.Size(209, 22);
            this.translateWord.TabIndex = 4;
            // 
            // translateResult
            // 
            this.translateResult.Enabled = false;
            this.translateResult.Location = new System.Drawing.Point(218, 256);
            this.translateResult.Name = "translateResult";
            this.translateResult.Size = new System.Drawing.Size(406, 101);
            this.translateResult.TabIndex = 0;
            this.translateResult.Text = "";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(524, 124);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(100, 88);
            this.goBtn.TabIndex = 5;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Square721 Cn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Translate";
            // 
            // dictionarySource
            // 
            this.dictionarySource.FormattingEnabled = true;
            this.dictionarySource.Location = new System.Drawing.Point(218, 124);
            this.dictionarySource.Name = "dictionarySource";
            this.dictionarySource.Size = new System.Drawing.Size(209, 24);
            this.dictionarySource.Sorted = true;
            this.dictionarySource.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dictionarySource);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.translateResult);
            this.Controls.Add(this.translateWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox translateWord;
        private System.Windows.Forms.RichTextBox translateResult;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dictionarySource;
    }
}

