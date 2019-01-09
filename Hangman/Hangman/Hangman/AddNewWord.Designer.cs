namespace Hangman
{
    partial class AddNewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWord));
            this.lbWords = new System.Windows.Forms.ListBox();
            this.gpAddNewWord = new System.Windows.Forms.GroupBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gpAddNewWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.ItemHeight = 16;
            this.lbWords.Location = new System.Drawing.Point(412, 19);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(289, 196);
            this.lbWords.TabIndex = 1;
            // 
            // gpAddNewWord
            // 
            this.gpAddNewWord.Controls.Add(this.btnAddWord);
            this.gpAddNewWord.Controls.Add(this.label1);
            this.gpAddNewWord.Controls.Add(this.tbWord);
            this.gpAddNewWord.Location = new System.Drawing.Point(26, 39);
            this.gpAddNewWord.Name = "gpAddNewWord";
            this.gpAddNewWord.Size = new System.Drawing.Size(356, 241);
            this.gpAddNewWord.TabIndex = 2;
            this.gpAddNewWord.TabStop = false;
            this.gpAddNewWord.Text = "Add word";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(99, 165);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(130, 43);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add your word here:";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(50, 71);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(239, 22);
            this.tbWord.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(497, 237);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 43);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove word";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AddNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 307);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gpAddNewWord);
            this.Controls.Add(this.lbWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewWord";
            this.Text = "AddNewWord";
            this.Load += new System.EventHandler(this.AddNewWord_Load);
            this.gpAddNewWord.ResumeLayout(false);
            this.gpAddNewWord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.GroupBox gpAddNewWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnRemove;
    }
}