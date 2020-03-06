import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Items } from '../Model/items';
import { TransactionHistory } from '../Model/transaction-history';


const Requestheaders={headers:new HttpHeaders({'content-Type':'application/json','Authorization': 'Bearer '+localStorage.getItem('token')})}



@Injectable({
  providedIn: 'root'
})



export class BuyerService {

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
}
