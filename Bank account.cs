namespace Demo

{
    class saving
    {
        string Name;
        private Int32 acc_no,balance;

        public void getName()
        {
            Console.Write(Name);
        }
        public void setName(String n)
        {
            //String n = Console.Readline()
            Name=n;
        }
        private void getAcc_no(Int32 a)
        {
            acc_no=a;
        }

        private getBalance()

        public static void Main(String [] args)
        {
            Saving s1= new Saving();
            s1.balance=500000;
            Console.write("Enter Name");
            string s=Console.Readline();
            s1.setName(s);
            s1.getName();
            Console.Write("Acc");
            Int32 a= Console.toInt32(Readline());
            s1.setAcc_no(a);
            s1.getAcc_no();
            s1.getBalance();
        }

    }
}    