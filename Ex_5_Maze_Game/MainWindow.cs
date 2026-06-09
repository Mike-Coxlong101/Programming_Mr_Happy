using System.Security.Cryptography.X509Certificates;

namespace Ex_6_Maze_Game
{
    public partial class




        MainWindow : Form
    {
        private Maze maze;
        private Player player;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Methode um Inhalte es Raums zu aktualisieren

        private void UpdateRoom()
        {
            labelPickable.Text = ("");
            labelWarnings.Text = ("");

            this.listBoxPlayer.Items.Clear();
            foreach (Item it in player.IsInBag())
            {
                this.listBoxPlayer.Items.Add(it);
            }

            this.listBoxRoom.Items.Clear();
            foreach (Item it in player.getCurrentRoom().IsContent())
            {
                this.listBoxRoom.Items.Add(it);
            }

        }




        private void move(char direction)
        {
            if (player.move(direction))
            {
                labelLocation.Text = player.getCurrentRoom().GetName();
                UpdateRoom(); // Die Listen werden geupdatet.
            }
            else
            {
                MessageBox.Show("You can't go in that direction!");
            }

            if (player.getCurrentRoom() == maze.getWinningRoom())
            {
                var result = MessageBox.Show("Congratulations! You won the maze! Would you like to replay?", "Glückwunsch", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No)
                {
                    Application.Exit(); //hier wird die Anwendung geschlossen wenn der Spieler nicht nochmal spielen möchte
                }

                MainWindow_Load(new(), new EventArgs()); //hier wird die Funktion MainWindow_Load aufgerufen damit das Spiel neu gestartet wird
            }
            else if (player.getCurrentRoom() == maze.getLosingRoom())
            {
                var result = MessageBox.Show("Oh no! You lost the maze! Would you like to play again", "Looser", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No)
                {
                    Application.Exit(); //hier wird die Anwendung geschlossen wenn der Spieler nicht nochmal spielen möchte
                }
                MainWindow_Load(new(), new EventArgs()); //hier wird die Funktion MainWindow_Load aufgerufen damit das Spiel neu gestartet wird
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            move('N');
        }


        //Wird automatisch ausgeführt wenn das Fenster geladen wird, hier werden die Instanzen von Maze und Player erstellt
        private void MainWindow_Load(object sender, EventArgs e)
        {

            maze = new Maze("maze");
            player = maze.GetPlayer();

            labelLocation.Text = player.getCurrentRoom().GetName();
            MessageBox.Show("Welcome to the Maze Game! Your goal is to find the winning room while avoiding the losing room. Use the buttons to move North, South, East, or West. Good luck!");
            UpdateRoom();
            labelPickable.Text = ("");
            labelWarnings.Text = ("");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            move('W');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            move('E');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            move('S');
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            Item ausgewaeltesItem = (Item)this.listBoxPlayer.SelectedItem;
            if (ausgewaeltesItem != null)
            {
                if (player.RemoveFromBag(ausgewaeltesItem))
                {
                    UpdateRoom();
                }

            }
        }

        private void PickupButton_Click(object sender, EventArgs e)
        {

            Item ausgewaeltesItem = (Item)this.listBoxRoom.SelectedItem;
            if (ausgewaeltesItem != null && ausgewaeltesItem.isPickable())
            {
                player.AddItemToBag(player.getCurrentRoom().RemoveFromRoom(ausgewaeltesItem));
                UpdateRoom();
                labelPickable.Text = ("Pickable");
            }
            else
            {
                labelPickable.Text = ("Not Pickable");
            }

        }

        private void listBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item clickedItem = (Item)this.listBoxRoom.SelectedItem;
            if (clickedItem != null && clickedItem.isPickable())
            {
                labelPickable.Text = ("Pickable");
            }
            else
            {
                labelPickable.Text = ("Not Pickable!");
                labelWarnings.Text = ("Too heavy");
            }
        }
    }
}
