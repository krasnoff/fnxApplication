import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Item } from '../Items/item';

@Injectable({
  providedIn: 'root'
})
export class GalleryService {

  constructor(private http: HttpClient) { }

  public getItems(searchWord: string) {
    return this.http.get<Item[]>('/api/Repositories/' + encodeURI(searchWord), {}).toPromise();
  }
}
