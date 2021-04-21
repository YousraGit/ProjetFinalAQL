﻿using System;

public class Note
{
     // c est moi
        public int NumeroEtudiant { get; set; }
        public string CodeCours { get; set; }
        public double NoteCours { get; set; }

        public Note(int numeroEtudiant, string codeCours, double noteCours)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.CodeCours = codeCours;
            this.NoteCours = noteCours;
        }



        public override string ToString()
        {
            return "Numéro Etudiant : " + this.NumeroEtudiant + "\n" +
                    "Code Cours : " + this.CodeCours + "\n" +
                   "Note Cours : " + this.NoteCours;
        }



        public override bool Equals(object obj)
        {
            if (!(obj is Note)) return false;



            Note note = (Note)obj;
            return note.NumeroEtudiant == this.NumeroEtudiant &&
                note.CodeCours == this.CodeCours &&
               note.NoteCours == this.NoteCours;
        }
    }
