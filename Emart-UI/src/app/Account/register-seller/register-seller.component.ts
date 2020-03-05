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
      sellerid:['',[Validators.required]],
      username:['',[Validators.required,Validators.pattern('^[a-z]{3,6}$')]],
      mobileno:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      emailid:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.minLength(6)]],
      postaladdress:['',Validators.required],
      gstin :['',Validators.required],
      website:['',[Validators.required,Validators.maxLength(25)]],
      companyname:['',[Validators.required,Validators.maxLength(30)]],
      briefdetails:['',[Validators.required,Validators.maxLength(70)]],
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
      this.seller.sellerid=this.registerForm.value["sellerid"];
      this.seller.username=this.registerForm.value["username"];
      this.seller.mobileno=(this.registerForm.value["mobileno"]);
      this.seller.companyname=this.registerForm.value["companyname"];
      this.seller.gstin=this.registerForm.value["gstin"];
      this.seller.password=this.registerForm.value["password"];
      this.seller.postaladdress=this.registerForm.value["postaladdress"];
      this.seller.website=this.registerForm.value["website"];
      this.seller.emailid=this.registerForm.value["emailid"];
      this.seller.briefdetails=this.registerForm.value["briefdetails"];
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

