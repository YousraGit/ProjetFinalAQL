using System;

public class Cours
{
    public int NumeroCours { get; set; }
    public string CodeCours { get; set; }
    public string TitreCours { get; set; }




    public Cours(int numeroCours, string codeCours, string titreCours)
    {
        this.NumeroCours = numeroCours;
        this.CodeCours = codeCours;
        this.TitreCours = titreCours;
    }



    public override string ToString()
    {
        return "Numéro de cours : " + this.NumeroCours + "\n" +
                "Code : " + this.CodeCours + "\n" +
                "Titre : " + this.TitreCours;
    }



    public override bool Equals(object obj)
    {
        if (!(obj is Cours)) return false;



        Cours cours = (Cours)obj;
        return cours.NumeroCours == this.NumeroCours &&
            cours.TitreCours == this.TitreCours &&
            cours.CodeCours == this.CodeCours;
    }
}
