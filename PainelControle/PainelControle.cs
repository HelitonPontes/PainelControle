namespace PainelControle
{
    public class PainelControle
    {
        public bool Ligar { get; set; }
        public bool Desligar { get; set; }
        public string Liga = "Ligado";
        public string Desliga = "Desligado";
        //public bool estado { get; set; }


        public bool LigarAlarme { get; set; }
        public bool DesligarAlarme { get; set; }
        public string LigaAlarme = "Ligado";
        public string DesligaAlarme = "Desligado";

        public bool LigarIluminação { get; set; }
        public bool DesligarIluminação { get; set; }
        public string LigaIluminação = "Ligado";
        public string DesligaIluminação = "Desligado";



        public void MLigarDesligar()

        {
            Ligar = false;

            if (Ligar == false && Desligar == false)
            {
                Desligar = true;
                Ligar = false;
                LigarIluminação = false;

            }

            else if (Desligar == true && Ligar == false)
            {
                Ligar = true;
                Desligar = false;

            }
        }


        public void MLigarDesligarAlarme()

        {
            LigarAlarme = false;

            if (LigarAlarme == false && DesligarAlarme == false && LigarAlarme == false)
            {

                LigarAlarme = false;
                LigarAlarme = false;
                DesligarAlarme = true;

            }

            else if (DesligarAlarme == true && Desligar == false)
            {
                LigarAlarme = true;
                DesligarAlarme = false;

            }
        }

        public void MIlminação()
        {

           if ( LigarIluminação == false)
            {
                LigarIluminação = true;
            } else
            {
                LigarIluminação = false;

            }if (DesligarIluminação == false)
            {
                DesligarIluminação = true;

            }else
            {
                DesligarIluminação = false;
            }
        }
    }

  
}
