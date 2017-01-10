using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise10_Part2;

namespace Exercise10_Part2Form
{
    public partial class HideAndSeek : Form
    {
        int Moves;
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        Opponent opponent;

        public HideAndSeek()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }
        private void RedrawForm()
        {
            exitsComboBox.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exitsComboBox.Items.Add(currentLocation.Exits[i].Name);
            exitsComboBox.SelectedIndex = 0;
            descriptionTextBox.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = "Check " + hidingPlace.HidingPlaceName;
                checkButton.Visible = true;
            }
            else
                checkButton.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoorButton.Visible = true;
            else
                goThroughTheDoorButton.Visible = false;
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                "inside the closet", "an oak door with a brass handle");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier",
                "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "in the cabinet", "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog",
                "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet",
                "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed",
                "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed",
                "under the bed");
            frontYard = new OutsideWithDoor("Front Yard", false, "a heavy-looking oak door");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                descriptionTextBox.Text = "You found your opponent in " + Moves
                + " moves! He was hiding " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hideButton.Visible = true;
            goHereButton.Visible = false;
            checkButton.Visible = false;
            goThroughTheDoorButton.Visible = false;
            exitsComboBox.Visible = false;
        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                descriptionTextBox.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            descriptionTextBox.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            goHereButton.Visible = true;
            exitsComboBox.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
