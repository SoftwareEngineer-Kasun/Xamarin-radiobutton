//onclick event

private void onClickRadioButton(object sender, EventArgs e) { 
   RadioButton cars = (RadioButton)sender; 
   Toast.MakeText(this, cars.Text, ToastLength.Short).Show 
   (); 
} 

// check clickboxes
RadioButton radio_Ferrari = FindViewById<RadioButton> 
   (Resource.Id.radioFerrari); 
   RadioButton radio_Mercedes = FindViewById<RadioButton> 
   (Resource.Id.radioMercedes); 
   RadioButton radio_Lambo = FindViewById<RadioButton> 
   (Resource.Id.radioLamborghini); 
   RadioButton radio_Audi = FindViewById<RadioButton> 
   (Resource.Id.radioAudi); 
   radio_Ferrari.Click += onClickRadioButton; 
   radio_Mercedes.Click += onClickRadioButton; 
   radio_Lambo.Click += onClickRadioButton; 
   radio_Audi.Click += onClickRadioButton; 
