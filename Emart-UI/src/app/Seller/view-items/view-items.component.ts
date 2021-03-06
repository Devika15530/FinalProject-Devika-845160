import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Items } from 'src/app/Model/items';
import { SellerService } from 'src/app/Services/seller.service';

import {Router} from '@angular/router';

@Component({
  selector: 'app-view-items',
  templateUrl: './view-items.component.html',
  styleUrls: ['./view-items.component.css']
})
export class ViewItemsComponent implements OnInit {
  itemForm:FormGroup;
  submitted=false;
 item:Items;
 itemlist:Items[];
//   categorylist:Category[];
// subcategorylist:SubCategory[];
//catid:string;
  constructor(private fromBuilder:FormBuilder,private service: SellerService,private route:Router)
   {
    this.service.ViewItems().subscribe(res=>{
      this.itemlist=res;
      console.log(this.itemlist);
 
   }
    )}
  ngOnInit() 
  {
    this.itemForm=this.fromBuilder.group({
    
       
        //SellerName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,15}$')]],
        ItemName:['',Validators.required],
        // CategoryId:['',[Validators.required,Validators.pattern("^[0-9]{1,5}$")]],
       Price:['',Validators.required],
        Description:['',Validators.required],
        CategoryId:[''],
        SellerId:[''],
         ItemId:[''],
        StockNumber:['',Validators.required],
        Remarks:[''],
        SubcategoryId:[''],
      
  
    });
  
  }
    
//     SellerId:[''],
      
//       ItemName:[''],
     
   
//      Price:[''],
//       Description:[''],
//       CategoryId:[''],
//       CategoryName:[''],
//       StockNumber:[''],
//       Remarks:[''],
//       SubcategoryId:['']

    

//   });

// }
DeleteItem(itemId:string)
{

  // let id=this.itemForm.value["itemId"];
  this.service.DeleteItem(itemId).subscribe
  (
    res=>
    {
      console.log('Record Deleted');
    },
    err=>
    {
      console.log(err);
    }
  )
}

GetItem(itemid:string)
 {
     this.service.GetItem(itemid).subscribe(res=>
        {
          this.item=res;
          console.log("get");
          console.log(this.item);
          console.log('Id Found');
          //console.log(res);
          this.itemForm.setValue(
            {
             
              ItemId:this.item.itemId,
              ItemName:this.item.itemName,
              Price:this.item.price,
              Description:this.item.description,
              StockNumber:this.item.stockNumber,
              SellerId:this.item.sellerId,
              CategoryId:this.item.categoryId,
              SubcategoryId:this.item.subcategoryId,
              Remarks:this.item.remarks,
              // Image:this.item.image
              
            }
          )
        },
        err=>
        {
          console.log(err);
        }
      )
     
    }
   
 
    Edit()
    {
      let item=new Items();
      console.log(item);
      
      item.itemId=this.itemForm.value["ItemId"];
      item.categoryId=this.itemForm.value["CategoryId"];
      item.sellerId=this.itemForm.value["SellerId"];
      item.subcategoryId=this.itemForm.value["SubcategoryId"]
      item.itemName=this.itemForm.value["ItemName"];
      // item.image=this.itemForm.value["image"];
      item.price=this.itemForm.value["Price"];
      item.stockNumber=this.itemForm.value["StockNumber"];
       item.description=this.itemForm.value["Description"];
      item.remarks=this.itemForm.value["Remarks"];
    this.service.UpdateItem(item).subscribe(res=>
    {
      console.log('Record updated')
      alert("Record Updated");
      this.route.navigateByUrl('/seller/view-items');
    })
      console.log(this.item);
     }
  
  

//console.log(this.item);


}


