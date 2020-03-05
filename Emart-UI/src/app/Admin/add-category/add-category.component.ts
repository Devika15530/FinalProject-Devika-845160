import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Category } from 'src/app/Model/category';
import { AdminService } from 'src/app/Services/admin.service';
@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {
  registerForm:FormGroup;
  submitted=false;
  category:Category;
  categorlist:Category[];
  constructor(private fromBuilder:FormBuilder,private service :AdminService) { }

  ngOnInit() {


    this.registerForm=this.fromBuilder.group({
      CategoryId:['',[Validators.required,Validators.maxLength(5)]],
      CategoryName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,25}$')]],
      BriefDetails:['',[Validators.required,Validators.pattern('^[a-zA-Z]{6,25}$')]]

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
    }
    this.Add();
  }
    onReset()
    {

    this.submitted=false;
    this.registerForm.reset();
    }


    Add()
    {
      this.category=new Category();
      this.category.categoryId='C'+Math.floor(Math.random()*100);;
      this.category.categoryName=this.registerForm.value["CategoryName"];
      this.category.briefDetails=this.registerForm.value["BriefDetails"];
      

      this.service.AddCategories(this.category).subscribe
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


