using System;

public class Etudiant
{
    public Etudiant(string nom, string prenom)
    {
        this.NumeroEtudiant = ++nombreEtudiants;
        this.Nom = nom;
        this.Prenom = prenom;
    }



    public override string ToString()
    {
        return "Numéro Etudiant : " + this.NumeroEtudiant + "\n" +
               "Nom : " + this.Nom + "\n" +
               "Prenom : " + this.Prenom;
    }



    public override bool Equals(object obj)
    {
        if (!(obj is Etudiant)) return false;



        Etudiant etudiant = (Etudiant)obj;
        return etudiant.NumeroEtudiant == this.NumeroEtudiant &&
            etudiant.Nom == this.Nom &&
            etudiant.Prenom == this.Prenom;
    }
}
