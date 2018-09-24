using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxJsonServer.Models {

	public class User {

		public Guid Id { get; set; } // guid
		public string Username { get; set; }
		public string Password { get; set; }
		public Guid AccessToken { get; set; } // guid

		public User(string Username, string Password, Guid AccessToken) {
			this.Id = Guid.NewGuid() ;
			this.Username = Username;
			this.Password = Password;
			this.AccessToken = AccessToken;
		}
		public User() {
		}
	}
}
