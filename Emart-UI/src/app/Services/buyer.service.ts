import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Items } from '../Model/items';
import { TransactionHistory } from '../Model/transaction-history';
import { Cart } from '../Model/cart';


const Requestheaders={headers:new HttpHeaders({'content-Type':'application/json','Authorization': 'Bearer '+localStorage.getItem('token')})}



@Injectable({
  providedIn: 'root'
})



export class BuyerService {
  ViewItems(itemName: string) {
    throw new Error("Method not implemented.");
  }

  url:string='http://localhost:53818/Buyer/'
  constructor(private http:HttpClient) { }



  public SearchItems(name:string) : Observable<Items[]>
  {
    return this.http.get<Items[]>(this.url+'SearchItem/'+name,Requestheaders)
  }

  public BuyItem(transactionhistory:TransactionHistory):Observable<TransactionHistory[]>
{
  return this.http.post<TransactionHistory[]>(this.url+'BuyItem/',transactionhistory,Requestheaders);
}




  public ViewCart() :Observable<Cart>
  {
    return this.http.get<Cart>(this.url+'ViewCart',Requestheaders);
   }

   public Addtocart(cartobj:Cart) :Observable<Cart>
  {
    return this.http.post<Cart>(this.url+'Addtocart',cartobj,Requestheaders);
   }

   public Deletefromcart(cartid:string) :Observable<Cart>
  {
    return this.http.delete<Cart>(this.url+'Deletefromcart/'+cartid,Requestheaders);
   }

}
