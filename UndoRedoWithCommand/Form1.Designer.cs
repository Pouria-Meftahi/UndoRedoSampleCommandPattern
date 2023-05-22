
namespace UndoRedoWithCommand
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetText = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetText
            // 
            this.btnSetText.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetText.Location = new System.Drawing.Point(12, 72);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(237, 52);
            this.btnSetText.TabIndex = 0;
            this.btnSetText.Text = "Set Text";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // Undo
            // 
            this.Undo.Image = global::UndoRedoWithCommand.Properties.Resources.undop;
            this.Undo.Location = new System.Drawing.Point(255, 72);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(63, 52);
            this.Undo.TabIndex = 1;
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.Image = global::UndoRedoWithCommand.Properties.Resources.redo;
            this.Redo.Location = new System.Drawing.Point(324, 72);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(63, 52);
            this.Redo.TabIndex = 2;
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 40);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.btnSetText);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetText;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

