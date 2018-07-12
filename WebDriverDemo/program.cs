namespace WebDriverDemo
{
    class program
    {
        static void Main(string[] args)
        {
            //ExecutarTestesBasicos();
            //ExecutarTestesBasicos2();
            ExecutarTestesBasicos3();
        }

        static void ExecutarTestesBasicos()
        {
            Basico.Go_To_Google_Firefox_Test();
            Basico.Go_To_Google_Chrome_Test();
            //Go_To_Google_Ie_Test();
        }

        static void ExecutarTestesBasicos2()
        {
            Basico2.Go_To_Google_Find_Element_Firefox();
        }

        static void ExecutarTestesBasicos3()
        {
            //Basico3.Set_RadionButton_Time();
            //Basico3.Set_SelectList_Devs();
            //Basico3.Set_SelectList_SelectElement_Devs();
            //Basico3.Get_Table();
            Basico3.Get_Table_XPath();
        }
    }
}
