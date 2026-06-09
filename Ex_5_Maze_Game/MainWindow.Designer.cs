namespace Ex_6_Maze_Game
{
    partial class MainWindow
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
            textMission = new TextBox();
            textBoxLocation = new TextBox();
            labelLocation = new Label();
            textBox1 = new TextBox();
            buttonN = new Button();
            buttonW = new Button();
            buttonE = new Button();
            buttonS = new Button();
            PlayerItemsLabel = new Label();
            RoomItemsLabel = new Label();
            listBoxRoom = new ListBox();
            listBoxPlayer = new ListBox();
            UseButton = new Button();
            DropButton = new Button();
            PickupButton = new Button();
            labelPickable = new Label();
            textBox2 = new TextBox();
            labelWarnings = new Label();
            SuspendLayout();
            // 
            // textMission
            // 
            textMission.Enabled = false;
            textMission.Location = new Point(12, 12);
            textMission.Multiline = true;
            textMission.Name = "textMission";
            textMission.Size = new Size(337, 120);
            textMission.TabIndex = 0;
            textMission.Text = "Your Mission:\r\nNavigate through the rooms of the old mansion and find\r\nthe exit. Avoid the HsChamber, because you would die instantly.\r\n";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Enabled = false;
            textBoxLocation.Location = new Point(647, 58);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(141, 27);
            textBoxLocation.TabIndex = 1;
            textBoxLocation.Text = "You are currently in:";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(659, 104);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(50, 20);
            labelLocation.TabIndex = 2;
            labelLocation.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(843, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Navigation:";
            // 
            // buttonN
            // 
            buttonN.Location = new Point(843, 353);
            buttonN.Name = "buttonN";
            buttonN.Size = new Size(94, 29);
            buttonN.TabIndex = 4;
            buttonN.Text = "N";
            buttonN.UseVisualStyleBackColor = true;
            buttonN.Click += buttonN_Click;
            // 
            // buttonW
            // 
            buttonW.Location = new Point(789, 388);
            buttonW.Name = "buttonW";
            buttonW.Size = new Size(94, 29);
            buttonW.TabIndex = 5;
            buttonW.Text = "W";
            buttonW.UseVisualStyleBackColor = true;
            buttonW.Click += buttonW_Click;
            // 
            // buttonE
            // 
            buttonE.Location = new Point(889, 388);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(94, 29);
            buttonE.TabIndex = 6;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = true;
            buttonE.Click += buttonE_Click;
            // 
            // buttonS
            // 
            buttonS.Location = new Point(843, 423);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(94, 29);
            buttonS.TabIndex = 7;
            buttonS.Text = "S";
            buttonS.UseVisualStyleBackColor = true;
            buttonS.Click += buttonS_Click;
            // 
            // PlayerItemsLabel
            // 
            PlayerItemsLabel.AutoSize = true;
            PlayerItemsLabel.Location = new Point(74, 266);
            PlayerItemsLabel.Name = "PlayerItemsLabel";
            PlayerItemsLabel.Size = new Size(71, 20);
            PlayerItemsLabel.TabIndex = 8;
            PlayerItemsLabel.Text = "You have:";
            // 
            // RoomItemsLabel
            // 
            RoomItemsLabel.AutoSize = true;
            RoomItemsLabel.Location = new Point(387, 266);
            RoomItemsLabel.Name = "RoomItemsLabel";
            RoomItemsLabel.Size = new Size(139, 20);
            RoomItemsLabel.TabIndex = 9;
            RoomItemsLabel.Text = "The romm contains:";
            // 
            // listBoxRoom
            // 
            listBoxRoom.FormattingEnabled = true;
            listBoxRoom.Location = new Point(387, 305);
            listBoxRoom.Name = "listBoxRoom";
            listBoxRoom.Size = new Size(174, 184);
            listBoxRoom.TabIndex = 10;
            listBoxRoom.SelectedIndexChanged += listBoxRoom_SelectedIndexChanged;
            // 
            // listBoxPlayer
            // 
            listBoxPlayer.FormattingEnabled = true;
            listBoxPlayer.Location = new Point(74, 305);
            listBoxPlayer.Name = "listBoxPlayer";
            listBoxPlayer.Size = new Size(175, 184);
            listBoxPlayer.TabIndex = 11;
            listBoxPlayer.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // UseButton
            // 
            UseButton.Location = new Point(112, 495);
            UseButton.Name = "UseButton";
            UseButton.Size = new Size(94, 29);
            UseButton.TabIndex = 12;
            UseButton.Text = "Use";
            UseButton.UseVisualStyleBackColor = true;
            // 
            // DropButton
            // 
            DropButton.Location = new Point(269, 333);
            DropButton.Name = "DropButton";
            DropButton.Size = new Size(94, 33);
            DropButton.TabIndex = 13;
            DropButton.Text = "Drop  >";
            DropButton.UseVisualStyleBackColor = true;
            DropButton.Click += DropButton_Click;
            // 
            // PickupButton
            // 
            PickupButton.Location = new Point(269, 401);
            PickupButton.Name = "PickupButton";
            PickupButton.Size = new Size(94, 29);
            PickupButton.TabIndex = 14;
            PickupButton.Text = "< Pickup";
            PickupButton.UseVisualStyleBackColor = true;
            PickupButton.Click += PickupButton_Click;
            // 
            // labelPickable
            // 
            labelPickable.AutoSize = true;
            labelPickable.Location = new Point(278, 433);
            labelPickable.Name = "labelPickable";
            labelPickable.Size = new Size(71, 20);
            labelPickable.TabIndex = 15;
            labelPickable.Text = "?Pickable";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 27);
            textBox2.TabIndex = 16;
            textBox2.Text = "Warnings:";
            // 
            // labelWarnings
            // 
            labelWarnings.AutoSize = true;
            labelWarnings.Location = new Point(160, 176);
            labelWarnings.Name = "labelWarnings";
            labelWarnings.Size = new Size(103, 20);
            labelWarnings.TabIndex = 17;
            labelWarnings.Text = "labelWarnings";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 626);
            Controls.Add(labelWarnings);
            Controls.Add(textBox2);
            Controls.Add(labelPickable);
            Controls.Add(PickupButton);
            Controls.Add(DropButton);
            Controls.Add(UseButton);
            Controls.Add(listBoxPlayer);
            Controls.Add(listBoxRoom);
            Controls.Add(RoomItemsLabel);
            Controls.Add(PlayerItemsLabel);
            Controls.Add(buttonS);
            Controls.Add(buttonE);
            Controls.Add(buttonW);
            Controls.Add(buttonN);
            Controls.Add(textBox1);
            Controls.Add(labelLocation);
            Controls.Add(textBoxLocation);
            Controls.Add(textMission);
            Name = "MainWindow";
            Text = "Maze Game";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMission;
        private TextBox textBoxLocation;
        private Label labelLocation;
        private TextBox textBox1;
        private Button buttonN;
        private Button buttonW;
        private Button buttonE;
        private Button buttonS;
        private Label PlayerItemsLabel;
        private Label RoomItemsLabel;
        private ListBox listBoxRoom;
        private ListBox listBoxPlayer;
        private Button UseButton;
        private Button DropButton;
        private Button PickupButton;
        private Label labelPickable;
        private TextBox textBox2;
        private Label labelWarnings;
    }
}
