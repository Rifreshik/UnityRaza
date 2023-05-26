using Firebase;
using Firebase.Database;
using UnityEngine;

public class MyScript: MonoBehaviour {
  void Start() {
    // Get the root reference location of the database.
    DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
  }
  public class User {
    public string username;
    public string email;

    public User() {
    }

    public User(string username, string email) {
        this.username = username;
        this.email = email;
    }
    }
   private void writeNewUser(string userId, string name, string email) {
    DatabaseReference mDatabaseRef = FirebaseDatabase.DefaultInstance.RootReference;

    User user = new User(name, email);
    string json = JsonUtility.ToJson(user);

    mDatabaseRef.Child("users").Child(userId).SetRawJsonValueAsync(json);
}
}