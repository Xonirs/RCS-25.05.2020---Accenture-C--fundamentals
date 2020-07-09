namespace Day18_Park
{
    class Program
    {
        //Create 2 classes – Gardener, Park. Gardener has properties – Name, Experience, Age. Park has properties – Name, Address, 
        //MainGardener. MainGardener is of type Gardener. Park has a public method – void PrintParkInfo(), which will print everything 
        //regarding the park, including the information about Gardener. In Program.Main create Park and Gardener objects. 
        //Reference the newly created Gardener object as the Park.MainGardener value. Use method PrintParkInfo().
        static void Main(string[] args)
        {
            #region 1st way
            //Park park = new Park()
            //{
            //    Address = "Merkela street 10",
            //    Name = "Vermanitis",
            //    MainGardener = new Gardener()
            //    {
            //        Age = 44,
            //        Experience = 14,
            //        Name = "Boriss"
            //    }
            //};
            #endregion

            #region 2nd way
            //Gardener gardener = new Gardener()
            //{
            //    Age = 44,
            //    Experience = 14,
            //    Name = "Boriss"
            //};

            //Park park = new Park()
            //{
            //    Address = "Merkela street 10",
            //    Name = "Vermanitis",
            //    MainGardener = gardener
            //};
            #endregion

            #region 3rd way
            Gardener gardener = new Gardener();
            gardener.Age = 44;
            gardener.Experience = 14;
            gardener.Name = "Boriss";
            Park park = new Park();
            park.Name = "Vermanitis";
            park.Address = "Merkela street 10";
            park.MainGardener = gardener;
            #endregion

            park.PrintParkInfo();
        }
    }
}
