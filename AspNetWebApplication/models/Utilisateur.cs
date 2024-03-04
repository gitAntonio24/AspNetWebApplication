using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetWebApplication.Models
{
    public class Utilisateur
    {
		private string _nomUtilisateur;
		private string _motdepasse;
		private string _email;

       

        public string Email
		{
			get { return _email; }
			set { _email = value; }
		}


		public string MotDePasse
		{
			get { return _motdepasse; }
			set { _motdepasse = value; }
		}


		public string NomUtilisateur
		{
			get { return _nomUtilisateur; }
			set { _nomUtilisateur = value; }
		}

        public Utilisateur() { }

        public Utilisateur(string nomUtilisateur, string motdepasse, string email)
        {
            _nomUtilisateur = nomUtilisateur;
            _motdepasse = motdepasse;
            _email = email;
        }

    }
}