using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IceTask3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinkedList lScripts = new LinkedList();
        public MainWindow()
        {
            InitializeComponent();
            List<Script> scripts = new List<Script>();
            scripts.Add(new Script(3, "With every line of code mastered, Alex gains experience points, leveling up and unlocking new abilities like Debugging Dash and Algorithmic Aura."));
            scripts.Add(new Script(12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams."));
            scripts.Add(new Script(4, "The Firewall Fortress looms ahead, its defenses formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks."));
            scripts.Add(new Script(2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom."));
            scripts.Add(new Script(1, "In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge."));
            scripts.Add(new Script(7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as \"Syntax Sentinels,\" united by their dedication to digital mastery."));
            scripts.Add(new Script(10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere."));
            scripts.Add(new Script(11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology."));
            scripts.Add(new Script(9, "In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes."));
            scripts.Add(new Script(5, "Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions."));
            scripts.Add(new Script(6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumored to contain the ultimate programming language."));
            scripts.Add(new Script(8, "The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm."));
            foreach (Script script in scripts)
            {
                lScripts.Add(script);
            }
        }

        private void btnShowScript_Click(object sender, RoutedEventArgs e)
        {
            txtViewScript.Clear();
            foreach (var script in lScripts) 
            {
                txtViewScript.AppendText(script.Data.Index() + ": " + script.Data.Line() + "\n");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtViewScript.Clear();
        }

        private void btnSortScript_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}