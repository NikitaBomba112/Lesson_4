using System.Xml.Serialization;

namespace Lesson_4
{
    public partial class Form1 : Form
    {
        FileStream stream;
        XmlSerializer serializer;

        public Form1()
        {
            InitializeComponent();
            stream = null;
            serializer = null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Human human = new Human(NameBox.Text, SurnameBox.Text, TelephoneBox.Text, EmailBox.Text);
            listBox1.Items.Add(human);
            NameBox.Text = "";
            SurnameBox.Text = "";
            TelephoneBox.Text = "";
            EmailBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Human human = new Human(NameBox.Text, SurnameBox.Text, TelephoneBox.Text, EmailBox.Text);
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items[index] = human;
            }

            NameBox.Text = "";
            SurnameBox.Text = "";
            TelephoneBox.Text = "";
            EmailBox.Text = "";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            List<Human> humans = new List<Human>();

            stream = new FileStream("data.xml", FileMode.Open);
            serializer = new XmlSerializer(typeof(List<Human>));
            humans = (List<Human>)serializer.Deserialize(stream);
            stream.Close();

            listBox1.Items.Clear();
            for (int i = 0; i < humans.Count; i++)
            {
                listBox1.Items.Add(humans[i]);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<Human> humans = new List<Human>();

            for (int i = 0; i < listBox1.Items.Count; i++) 
            {
                humans.Add((Human)listBox1.Items[i]);
            }

            stream = new FileStream("data.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(List<Human>));
            serializer.Serialize(stream, humans);
            stream.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
