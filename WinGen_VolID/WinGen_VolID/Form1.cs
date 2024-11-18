using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGen_VolID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenHWID_Click(object sender, EventArgs e)
        {
            string hwid = GenVolID();
            HWID.Text = hwid;
        }
        private string GenVolID()
        {
            Random random = new Random();
            string hexCharacters = "0123456789ABCDEF";
            string hwid = "";

            for (int i = 0; i < 4; i++)  // Generate 4 characters for the first segment
            {
                hwid += hexCharacters[random.Next(hexCharacters.Length)];
            }

            hwid += "-";

            for (int i = 0; i < 4; i++)  // Generate 4 characters for the second segment
            {
                hwid += hexCharacters[random.Next(hexCharacters.Length)];
            }

            return hwid;
        }

        private void ChangeHWID_Click(object sender, EventArgs e)
        {
 // Validate the HWID format using a regular expression or similar mechanism
    bool isValidHWID = ValidateHWID(this.TextBox1.Text);

    if (isValidHWID)
    {
        // Prepare and start the process
        var info1 = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c Volumeid.exe {this.ComboBox1.SelectedItem} {this.TextBox1.Text}",
            WindowStyle = ProcessWindowStyle.Hidden,
            CreateNoWindow = true
        };

        try
        {
            Process.Start(info1);
            MessageBox.Show("HWID Changed. Please reboot PC to apply it.", "HWID Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error starting process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        MessageBox.Show("Invalid HWID. Please enter a valid HWID.", "Invalid HWID", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

// A method to validate HWID format - implement your own validation logic
private bool ValidateHWID(string hwid)
{
    // Example of a simple validation using a regex pattern
    var pattern = @"^[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}$";
    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
    return regex.IsMatch(hwid);
}

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get all drive info
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Check if the Volumeid.exe file exists and create it if it doesn't
            string volumeIdPath = Path.Combine(Application.StartupPath, "Volumeid.exe");
            if (!File.Exists(volumeIdPath))
            {
                File.WriteAllBytes(volumeIdPath, Resources.Volumeid);
            }

            // Populate ComboBox with drive names
            foreach (var drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed) // Fixed drive type is used for local drives
                {
                    // Remove the trailing backslash from the drive name if present
                    string driveName = drive.Name.TrimEnd(Path.DirectorySeparatorChar);
                    this.ComboBox1.Items.Add(driveName);
                }
            }

            // Set the selected index to the first item in the ComboBox
            if (this.ComboBox1.Items.Count > 0)
            {
                this.ComboBox1.SelectedIndex = 0;
            }
        }
        }
        }
