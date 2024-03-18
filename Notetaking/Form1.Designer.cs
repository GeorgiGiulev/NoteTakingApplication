namespace Notetaking
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
            label1 = new Label();
            buttonNewNote = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            noteTitle = new TextBox();
            noteNote = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // buttonNewNote
            // 
            buttonNewNote.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNewNote.Location = new Point(38, 381);
            buttonNewNote.Name = "buttonNewNote";
            buttonNewNote.Size = new Size(75, 33);
            buttonNewNote.TabIndex = 1;
            buttonNewNote.Text = "NEW";
            buttonNewNote.UseVisualStyleBackColor = true;
            buttonNewNote.Click += buttonNewNote_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(176, 381);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 33);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(306, 381);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 33);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // noteTitle
            // 
            noteTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteTitle.Location = new Point(8, 100);
            noteTitle.Name = "noteTitle";
            noteTitle.Size = new Size(239, 29);
            noteTitle.TabIndex = 5;
            // 
            // noteNote
            // 
            noteNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteNote.Location = new Point(8, 171);
            noteNote.Multiline = true;
            noteNote.Name = "noteNote";
            noteNote.Size = new Size(239, 140);
            noteNote.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 143);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 7;
            label2.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 8;
            label3.Text = "All Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(587, 24);
            label4.Name = "label4";
            label4.Size = new Size(186, 39);
            label4.TabIndex = 9;
            label4.Text = "NoteTakingApp";
            // 
            // listView
            // 
            listView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listView.Location = new Point(306, 100);
            listView.Name = "listView";
            listView.Size = new Size(423, 237);
            listView.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(noteNote);
            Controls.Add(noteTitle);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(buttonNewNote);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonNewNote;
        private Button saveButton;
        private Button deleteButton;
        private TextBox noteTitle;
        private TextBox noteNote;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView listView;
    }
}
