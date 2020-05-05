import { Injectable } from '@angular/core';
import { BookDetail } from './book-detail.model';
import { HttpClient} from "@angular/common/http"

@Injectable({
  providedIn: 'root'
})
export class BookDetailService {
  formData:BookDetail = {
    BKID: 0,
    BookName: null,
    Author: null
  };
  readonly rootURL = "http://localhost:5001/api";
  list: BookDetail[];


  constructor(private http:HttpClient) { }

  postBookDetail() {
    return this.http.post(this.rootURL+'/BookDetail',this.formData);
  }
  putBookDetail() {
    return this.http.put(this.rootURL+'/BookDetail/'+this.formData.BKID,this.formData);
  }
  deleteBookDetail(BKID) {
    return this.http.delete(this.rootURL+'/BookDetail/'+BKID);
  }

  refreshList() {
    this.http.get(this.rootURL + '/BookDetail')
    .toPromise()
    .then(res => this.list = res as BookDetail[]);
  }
}
