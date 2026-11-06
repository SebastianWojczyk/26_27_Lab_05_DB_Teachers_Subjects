namespace _26_27_Lab_05_DB_Teachers_Subjects
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
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelSubjects = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(13, 13);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(270, 394);
            this.listBoxTeachers.TabIndex = 0;
            this.listBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.listBoxTeachers_SelectedIndexChanged);
            // 
            // flowLayoutPanelSubjects
            // 
            this.flowLayoutPanelSubjects.AutoScroll = true;
            this.flowLayoutPanelSubjects.Location = new System.Drawing.Point(290, 13);
            this.flowLayoutPanelSubjects.Name = "flowLayoutPanelSubjects";
            this.flowLayoutPanelSubjects.Size = new System.Drawing.Size(366, 396);
            this.flowLayoutPanelSubjects.TabIndex = 1;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Location = new System.Drawing.Point(290, 415);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(156, 23);
            this.buttonAddSubject.TabIndex = 3;
            this.buttonAddSubject.Text = "Dodaj przedmiot";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(500, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz zmiany";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.flowLayoutPanelSubjects);
            this.Controls.Add(this.listBoxTeachers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSubjects;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonSave;
    }
}

