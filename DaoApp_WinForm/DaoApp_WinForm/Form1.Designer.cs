namespace DaoApp_WinForm
{
	partial class Form_Main
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox_script = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button_template = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_run = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer_result = new System.Windows.Forms.SplitContainer();
			this.textBox_param = new System.Windows.Forms.TextBox();
			this.textBox_function = new System.Windows.Forms.TextBox();
			this.richTextBox_result = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_result)).BeginInit();
			this.splitContainer_result.Panel1.SuspendLayout();
			this.splitContainer_result.Panel2.SuspendLayout();
			this.splitContainer_result.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox_script
			// 
			this.richTextBox_script.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_script.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_script.Name = "richTextBox_script";
			this.richTextBox_script.Size = new System.Drawing.Size(479, 226);
			this.richTextBox_script.TabIndex = 0;
			this.richTextBox_script.Text = "代码区";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button_template);
			this.splitContainer1.Panel1.Controls.Add(this.button_clear);
			this.splitContainer1.Panel1.Controls.Add(this.button_run);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(724, 456);
			this.splitContainer1.SplitterDistance = 241;
			this.splitContainer1.TabIndex = 1;
			// 
			// button_template
			// 
			this.button_template.Location = new System.Drawing.Point(90, 82);
			this.button_template.Name = "button_template";
			this.button_template.Size = new System.Drawing.Size(75, 23);
			this.button_template.TabIndex = 2;
			this.button_template.Text = "template";
			this.button_template.UseVisualStyleBackColor = true;
			// 
			// button_clear
			// 
			this.button_clear.Location = new System.Drawing.Point(90, 202);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(75, 23);
			this.button_clear.TabIndex = 1;
			this.button_clear.Text = "clear";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// button_run
			// 
			this.button_run.Location = new System.Drawing.Point(90, 136);
			this.button_run.Name = "button_run";
			this.button_run.Size = new System.Drawing.Size(75, 23);
			this.button_run.TabIndex = 0;
			this.button_run.Text = "run";
			this.button_run.UseVisualStyleBackColor = true;
			this.button_run.Click += new System.EventHandler(this.button_run_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.richTextBox_script);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer_result);
			this.splitContainer2.Size = new System.Drawing.Size(479, 456);
			this.splitContainer2.SplitterDistance = 226;
			this.splitContainer2.TabIndex = 0;
			// 
			// splitContainer_result
			// 
			this.splitContainer_result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_result.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_result.Name = "splitContainer_result";
			this.splitContainer_result.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_result.Panel1
			// 
			this.splitContainer_result.Panel1.Controls.Add(this.textBox_param);
			this.splitContainer_result.Panel1.Controls.Add(this.textBox_function);
			// 
			// splitContainer_result.Panel2
			// 
			this.splitContainer_result.Panel2.Controls.Add(this.richTextBox_result);
			this.splitContainer_result.Size = new System.Drawing.Size(479, 226);
			this.splitContainer_result.SplitterDistance = 49;
			this.splitContainer_result.TabIndex = 1;
			// 
			// textBox_param
			// 
			this.textBox_param.Location = new System.Drawing.Point(148, 15);
			this.textBox_param.Name = "textBox_param";
			this.textBox_param.Size = new System.Drawing.Size(204, 21);
			this.textBox_param.TabIndex = 1;
			this.textBox_param.Text = "parameter: split with \',\'";
			// 
			// textBox_function
			// 
			this.textBox_function.Location = new System.Drawing.Point(29, 15);
			this.textBox_function.Name = "textBox_function";
			this.textBox_function.Size = new System.Drawing.Size(100, 21);
			this.textBox_function.TabIndex = 0;
			this.textBox_function.Text = "function";
			// 
			// richTextBox_result
			// 
			this.richTextBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_result.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_result.Name = "richTextBox_result";
			this.richTextBox_result.Size = new System.Drawing.Size(479, 173);
			this.richTextBox_result.TabIndex = 0;
			this.richTextBox_result.Text = "";
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 456);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form_Main";
			this.Text = "Form";
			this.Load += new System.EventHandler(this.Form_Main_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer_result.Panel1.ResumeLayout(false);
			this.splitContainer_result.Panel1.PerformLayout();
			this.splitContainer_result.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_result)).EndInit();
			this.splitContainer_result.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox_script;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button_template;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_run;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer_result;
		private System.Windows.Forms.TextBox textBox_param;
		private System.Windows.Forms.TextBox textBox_function;
		private System.Windows.Forms.RichTextBox richTextBox_result;
	}
}

