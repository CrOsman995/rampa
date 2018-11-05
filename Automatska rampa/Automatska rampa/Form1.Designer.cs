namespace Automatska_rampa
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
            this.not_car_at_gate = new System.Windows.Forms.TextBox();
            this.car_at_gate = new System.Windows.Forms.TextBox();
            this.not_car_just_exited = new System.Windows.Forms.TextBox();
            this.car_just_exited = new System.Windows.Forms.TextBox();
            this.btt_start = new System.Windows.Forms.Button();
            this.gate_bottom = new System.Windows.Forms.PictureBox();
            this.gate_top = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gate_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate_top)).BeginInit();
            this.SuspendLayout();
            // 
            // not_car_at_gate
            // 
            this.not_car_at_gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.not_car_at_gate.Location = new System.Drawing.Point(92, 200);
            this.not_car_at_gate.Multiline = true;
            this.not_car_at_gate.Name = "not_car_at_gate";
            this.not_car_at_gate.Size = new System.Drawing.Size(100, 50);
            this.not_car_at_gate.TabIndex = 0;
            // 
            // car_at_gate
            // 
            this.car_at_gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.car_at_gate.Location = new System.Drawing.Point(211, 200);
            this.car_at_gate.Multiline = true;
            this.car_at_gate.Name = "car_at_gate";
            this.car_at_gate.Size = new System.Drawing.Size(100, 50);
            this.car_at_gate.TabIndex = 1;
            // 
            // not_car_just_exited
            // 
            this.not_car_just_exited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.not_car_just_exited.Location = new System.Drawing.Point(343, 200);
            this.not_car_just_exited.Multiline = true;
            this.not_car_just_exited.Name = "not_car_just_exited";
            this.not_car_just_exited.Size = new System.Drawing.Size(100, 50);
            this.not_car_just_exited.TabIndex = 2;
            // 
            // car_just_exited
            // 
            this.car_just_exited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.car_just_exited.Location = new System.Drawing.Point(465, 200);
            this.car_just_exited.Multiline = true;
            this.car_just_exited.Name = "car_just_exited";
            this.car_just_exited.Size = new System.Drawing.Size(100, 50);
            this.car_just_exited.TabIndex = 3;
            // 
            // btt_start
            // 
            this.btt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btt_start.Location = new System.Drawing.Point(59, 57);
            this.btt_start.Name = "btt_start";
            this.btt_start.Size = new System.Drawing.Size(101, 63);
            this.btt_start.TabIndex = 4;
            this.btt_start.Text = "Start";
            this.btt_start.UseVisualStyleBackColor = true;
            this.btt_start.Click += new System.EventHandler(this.btt_start_Click);
            // 
            // gate_bottom
            // 
            this.gate_bottom.BackColor = System.Drawing.Color.Red;
            this.gate_bottom.Location = new System.Drawing.Point(317, 120);
            this.gate_bottom.Name = "gate_bottom";
            this.gate_bottom.Size = new System.Drawing.Size(20, 100);
            this.gate_bottom.TabIndex = 5;
            this.gate_bottom.TabStop = false;
            // 
            // gate_top
            // 
            this.gate_top.BackColor = System.Drawing.Color.Green;
            this.gate_top.Location = new System.Drawing.Point(343, 100);
            this.gate_top.Name = "gate_top";
            this.gate_top.Size = new System.Drawing.Size(100, 20);
            this.gate_top.TabIndex = 6;
            this.gate_top.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 326);
            this.Controls.Add(this.gate_top);
            this.Controls.Add(this.gate_bottom);
            this.Controls.Add(this.btt_start);
            this.Controls.Add(this.car_just_exited);
            this.Controls.Add(this.not_car_just_exited);
            this.Controls.Add(this.car_at_gate);
            this.Controls.Add(this.not_car_at_gate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gate_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox not_car_at_gate;
        private System.Windows.Forms.TextBox car_at_gate;
        private System.Windows.Forms.TextBox not_car_just_exited;
        private System.Windows.Forms.TextBox car_just_exited;
        private System.Windows.Forms.Button btt_start;
        private System.Windows.Forms.PictureBox gate_bottom;
        private System.Windows.Forms.PictureBox gate_top;
    }
}

