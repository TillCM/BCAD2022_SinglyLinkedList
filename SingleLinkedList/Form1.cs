using SingleLinkedList.CLinkedLists;

namespace SingleLinkedList
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SLinkedList slinkedList = new SLinkedList();
            List<String> nodesList = new List<String>();
            slinkedList.appendNode("I am the Head");
            slinkedList.appendNode("I am the Second Node");
            slinkedList.appendNode("I am the Third Node");

            slinkedList.prepend("I am the new head");
            slinkedList.prepend("Mwhahaha I am the new head now");
            slinkedList.prepend("Look at me, I am the Captain now");

            //slinkedList.deteleWithData("I am the Second Node");
            //slinkedList.applyProfanityFilter("am");
            slinkedList.insertAfter("I have been inserted After", "Look at me, I am the Captain now");
            nodesList = slinkedList.showNext();

            foreach (string item in nodesList)
            {
                MessageBox.Show(item);
            }

            

           
            
        }
    }
}