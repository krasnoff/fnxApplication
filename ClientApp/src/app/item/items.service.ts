import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Item } from '../Items/item';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(private http: HttpClient) { }

  public getBookmarks() {
    return this.http.get<Item[]>('/api/Repositories/getBookmarks').toPromise();
  }

  public postBookmarks(item: Item) {
    return this.http.post('/api/Repositories/addBookmark', item).toPromise();
  }
}
