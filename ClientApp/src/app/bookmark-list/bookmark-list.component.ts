import { Component, OnInit } from '@angular/core';
import { Item } from '../Items/item';
import { ItemsService } from '../item/items.service';

@Component({
  selector: 'app-bookmark-list',
  templateUrl: './bookmark-list.component.html',
  styleUrls: ['../gallery/gallery.component.css']
})
export class BookmarkListComponent implements OnInit {

  itemsList: Item[] = [];

  constructor(public itemService: ItemsService) { }

  ngOnInit() {
    this._init();
  }

  async _init() {
    this.itemsList = await this.itemService.getBookmarks();
    console.log(this.itemsList);
  }

}
