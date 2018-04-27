using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            //TODO: Finish UpdateCharacters() method. Add names for picture boxes and hit points table.

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }

            if (showBat) bat.Visible = true;
            else bat.Visible = false;
            if (showGhost) ghost.Visible = true;
            else ghost.Visible = false;
            if (showGhoul) ghoul.Visible = true;
            else ghoul.Visible = false;

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Mace":
                    weaponControl = mace; break;
            }
            weaponControl.Visible = true;

            //TODO: Set the Visible property on each inventory icon PictureBox.
            //  Check the Game object’s CheckPlayerInventory() method to figure out whether or not to
            //display the various inventory icons.

            invSword.Visible = false;
            invBow.Visible = false;
            invMace.Visible = false;
            invBluePotion.Visible = false;
            invRedPotion.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if(game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if(enemiesShown<1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        public Form1()
        {
            InitializeComponent();
            game = new Game(new Rectangle(99, 80, 540, 219));
            game.NewLevel(random);
            UpdateCharacters();
            buttonMoveUp.KeyDown += new KeyEventHandler(Form1_KeyDown);
            buttonMoveDown.KeyDown += new KeyEventHandler(Form1_KeyDown);
            buttonMoveRight.KeyDown += new KeyEventHandler(Form1_KeyDown);
            buttonMoveLeft.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonAttackUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttackDown_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttackRight_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up)
            {
               
                    game.Move(Direction.Up, random);
                    UpdateCharacters();
                    System.Threading.Thread.Sleep(100);
                
            }

            if (e.KeyCode == Keys.Down)
            {
                
                    game.Move(Direction.Down, random);
                    UpdateCharacters();
                    System.Threading.Thread.Sleep(100);
                
            }

            if (e.KeyCode == Keys.Right)
            {
                
                    game.Move(Direction.Right, random);
                    UpdateCharacters();
                    System.Threading.Thread.Sleep(100);
                
            }

            if (e.KeyCode == Keys.Left)
            {
                
                    game.Move(Direction.Left, random);
                    UpdateCharacters();
                    System.Threading.Thread.Sleep(100);
                
            }
        }

        private void buttonMoveUp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
