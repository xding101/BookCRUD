import { Component, OnInit } from '@angular/core';
import { BookDetailService } from 'src/app/shared/book-detail.service';
import { BookDetail } from 'src/app/shared/book-detail.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-book-detail-list',
  templateUrl: './book-detail-list.component.html',
  styles: [
  ]
})
export class BookDetailListComponent implements OnInit {

  constructor(public service: BookDetailService,
    private toastr: ToastrService) { }
    values = '';
    match = false;

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(book:BookDetail) {
    this.service.formData = Object.assign({}, book);
  }

  onDelete(BKID) {
    if(confirm('Are you sure to delete this record?')) {
      this.service.deleteBookDetail(BKID)
     .subscribe(res => {
      this.service.refreshList();
      },
      err=> {
        console.log(err);
        this.toastr.warning('Deleted successfully', 'Book Shelf');
      });
    }
    
  }
  onKey(value: string) {
    this.values = value ;
  }

}

