﻿namespace omertekesntpperformansı
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.talepnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaçnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taleptarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneNTPDataSet = new omertekesntpperformansı.eczaneNTPDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eczaneNTPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talepTableAdapter = new omertekesntpperformansı.eczaneNTPDataSetTableAdapters.talepTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneNTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneNTPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(159, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 39);
            this.button2.TabIndex = 46;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(2, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 47;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepnoDataGridViewTextBoxColumn,
            this.canoDataGridViewTextBoxColumn,
            this.musnoDataGridViewTextBoxColumn,
            this.ilaçnoDataGridViewTextBoxColumn,
            this.taleptarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.talepBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(316, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(484, 291);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // talepnoDataGridViewTextBoxColumn
            // 
            this.talepnoDataGridViewTextBoxColumn.DataPropertyName = "talepno";
            this.talepnoDataGridViewTextBoxColumn.HeaderText = "talepno";
            this.talepnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.talepnoDataGridViewTextBoxColumn.Name = "talepnoDataGridViewTextBoxColumn";
            this.talepnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // canoDataGridViewTextBoxColumn
            // 
            this.canoDataGridViewTextBoxColumn.DataPropertyName = "cano";
            this.canoDataGridViewTextBoxColumn.HeaderText = "cano";
            this.canoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.canoDataGridViewTextBoxColumn.Name = "canoDataGridViewTextBoxColumn";
            // 
            // musnoDataGridViewTextBoxColumn
            // 
            this.musnoDataGridViewTextBoxColumn.DataPropertyName = "musno";
            this.musnoDataGridViewTextBoxColumn.HeaderText = "musno";
            this.musnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musnoDataGridViewTextBoxColumn.Name = "musnoDataGridViewTextBoxColumn";
            // 
            // ilaçnoDataGridViewTextBoxColumn
            // 
            this.ilaçnoDataGridViewTextBoxColumn.DataPropertyName = "ilaçno";
            this.ilaçnoDataGridViewTextBoxColumn.HeaderText = "ilaçno";
            this.ilaçnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilaçnoDataGridViewTextBoxColumn.Name = "ilaçnoDataGridViewTextBoxColumn";
            // 
            // taleptarihiDataGridViewTextBoxColumn
            // 
            this.taleptarihiDataGridViewTextBoxColumn.DataPropertyName = "taleptarihi";
            this.taleptarihiDataGridViewTextBoxColumn.HeaderText = "taleptarihi";
            this.taleptarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taleptarihiDataGridViewTextBoxColumn.Name = "taleptarihiDataGridViewTextBoxColumn";
            // 
            // talepBindingSource
            // 
            this.talepBindingSource.DataMember = "talep";
            this.talepBindingSource.DataSource = this.eczaneNTPDataSet;
            // 
            // eczaneNTPDataSet
            // 
            this.eczaneNTPDataSet.DataSetName = "eczaneNTPDataSet";
            this.eczaneNTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "İlac No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Müşteri No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Çalışan No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Talep Tarihi:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 154);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 39;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 186);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 122);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 37;
            // 
            // eczaneNTPDataSetBindingSource
            // 
            this.eczaneNTPDataSetBindingSource.DataSource = this.eczaneNTPDataSet;
            this.eczaneNTPDataSetBindingSource.Position = 0;
            // 
            // talepTableAdapter
            // 
            this.talepTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(316, 22);
            this.textBox6.TabIndex = 48;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "İlaç Talep";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneNTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneNTPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource eczaneNTPDataSetBindingSource;
        private eczaneNTPDataSet eczaneNTPDataSet;
        private System.Windows.Forms.BindingSource talepBindingSource;
        private eczaneNTPDataSetTableAdapters.talepTableAdapter talepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaçnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taleptarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
    }
}