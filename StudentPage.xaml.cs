using AssignmentMauiConnectFireStoreDB.Services;
using AssignmentMauiConnectFireStoreDB.ViewModels;

namespace AssignmentMauiConnectFireStoreDB;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
        var firestoreService = new FirestoreService();
        BindingContext = new StudentViewModel(firestoreService);
    }
}