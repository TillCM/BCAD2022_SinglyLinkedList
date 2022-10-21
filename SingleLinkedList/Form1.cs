using SingleLinkedList.CLinkedLists;
using SingleLinkedList.Queue;

namespace SingleLinkedList
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            /*CircleLinkedList<string> list = new CircleLinkedList<string>();
            list.appendNode("mikr");

            CircleLinkedList<int> list2 = new CircleLinkedList<int>();
            list2.appendNode(5);

            CircleLinkedList<Person> peoplelist = new CircleLinkedList<Person>();
            peoplelist.appendNode(new Person { MyProperty =1 });*/

            //CircleLinkedList<string> slinkedList = new CircleLinkedList<string>();
            //List<String> nodesList = new List<String>();
            //slinkedList.appendNode("I am the Head");
            //slinkedList.appendNode("I am the Second Node");
            //slinkedList.appendNode("I am the Third Node");

            //slinkedList.prepend("I am the new head");
            //slinkedList.prepend("Mwhahaha I am the new head now");
            //slinkedList.prepend("Look at me, I am the Captain now");

            ////slinkedList.deteleWithData("I am the Second Node");
            ////slinkedList.applyProfanityFilter("am");
            //slinkedList.insertAfter("I have been inserted After", "Look at me, I am the Captain now");
            //nodesList = slinkedList.showNext();

            //foreach (string item in nodesList)
            //{
            //    MessageBox.Show(item);
            //}

            CQueue<string> testQ = new CQueue<string>();
            testQ.Enqueue("Yadav");
            testQ.Enqueue("Katelyn");
            testQ.Enqueue("Neil");

            MessageBox.Show(testQ.peek());

            
           
            
        }
    }
}