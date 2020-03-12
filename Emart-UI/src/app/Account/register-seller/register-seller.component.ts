import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Seller } from 'src/app/Model/seller';
import { AccountService } from 'src/app/Services/account.service';
@Component({
  selector: 'app-register-seller',
  templateUrl: './register-seller.component.html',
  styleUrls: ['./register-seller.component.css']
})
export class RegisterSellerComponent implements OnInit {
  registerForm:FormGroup;
  submitted=false;
seller:Seller;
sellerlist:Seller[];


  constructor(private fromBuilder:FormBuilder,private service: AccountService) { }

  ngOnInit() {
    this.registerForm=this.fromBuilder.group({
      // title:['',Validators.required],
  
      userName:['',[Validators.required,Validators.pattern('^[a-z]{3,6}$')]],
      mobileNo:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      emailId:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.minLength(6)]],
      postalAddress:['',Validators.required],
      gstin :['',Validators.required],
      website:['',[Validators.required,Validators.maxLength(25)]],
      companyName:['',[Validators.required,Validators.maxLength(30)]],
      briefDetails:['',[Validators.required,Validators.maxLength(70)]],
      // acceptTerms:[false,Validators.requiredTrue]
    
    });
  




  }


  get f()
  {
    return this.registerForm.controls;

  }
  
  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.registerForm.valid)
    {
      alert('sucess!!!!!!')
      console.log(JSON.stringify(this.registerForm.value));
      this.Register();
    }
  }
    onReset()
    {

    this.submitted=false;
    this.registerForm.reset();
    }

    Register()
    {

      this.seller=new Seller();
      this.seller.sellerId='C'+Math.floor(Math.random()*100);;
      this.seller.userName=this.registerForm.value["userName"];
      this.seller.mobileNo=(this.registerForm.value["mobileNo"]);
      this.seller.companyName=this.registerForm.value["companyName"];
      this.seller.gstin=this.registerForm.value["gstin"];
      this.seller.password=this.registerForm.value["password"];
      this.seller.postalAddress=this.registerForm.value["postalAddress"];
      this.seller.website=this.registerForm.value["website"];
      this.seller.emailId=this.registerForm.value["emailId"];
      this.seller.briefDetails=this.registerForm.value["briefDetails"];
      this.service.RegisterSeller(this.seller).subscribe
      (
        res=>
        {
          console.log('Record Added');
        },
        err=>
        {
          console.log(err);
        }
      )
    }
}

