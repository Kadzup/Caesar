
namespace Caesar
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
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.TextBox();
            this.frequencyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(12, 277);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(139, 31);
            this.encode.TabIndex = 0;
            this.encode.Text = "Зашифрувати";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(157, 277);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(139, 31);
            this.decode.TabIndex = 1;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вхідний текст";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 29);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputText.Size = new System.Drawing.Size(139, 242);
            this.inputText.TabIndex = 3;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(157, 29);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(139, 242);
            this.outputText.TabIndex = 5;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вихідний текст";
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(302, 29);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(228, 20);
            this.keyField.TabIndex = 6;
            this.keyField.TextChanged += new System.EventHandler(this.keyField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Частотний аналіз";
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(302, 68);
            this.frequency.Multiline = true;
            this.frequency.Name = "frequency";
            this.frequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.frequency.Size = new System.Drawing.Size(228, 203);
            this.frequency.TabIndex = 10;
            // 
            // frequencyButton
            // 
            this.frequencyButton.Location = new System.Drawing.Point(302, 277);
            this.frequencyButton.Name = "frequencyButton";
            this.frequencyButton.Size = new System.Drawing.Size(228, 31);
            this.frequencyButton.TabIndex = 9;
            this.frequencyButton.Text = "Розшифрувати";
            this.frequencyButton.UseVisualStyleBackColor = true;
            this.frequencyButton.Click += new System.EventHandler(this.frequencyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 320);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.frequencyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Caesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.Button frequencyButton;
    }
}

