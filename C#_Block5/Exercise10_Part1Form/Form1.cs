using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise10_Part1;

namespace Exercise10_Part1Form
{
    public partial class ExploreTheHouseForm : Form
    {
        HouseMove houseMove;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutSideWithDoor frontYard;
        OutSideWithDoor backYard;
        Outside garden;
        public ExploreTheHouseForm()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void MoveToANewLocation(Location location)
        {
            houseMove.MoveToANewLocation(location);
            exitsComboBox.Items.Clear();
            foreach (Location l in houseMove.CurrentLocation.Exits)
                exitsComboBox.Items.Add(l.Name);
            exitsComboBox.SelectedIndex = 0;

            descriptionTextBox.Text = houseMove.CurrentLocation.Description;
            if (houseMove.CurrentLocation is IHasExteriorDoor)
                goThroughTheDoorButton.Visible = true;
            else
                goThroughTheDoorButton.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");
            frontYard = new OutSideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutSideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            houseMove = new HouseMove(livingRoom);
        }

        private void ExploreTheHouseForm_Load(object sender, EventArgs e)
        {

        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(houseMove.CurrentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = houseMove.CurrentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
