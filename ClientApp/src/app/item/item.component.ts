import { Component, OnInit, Input } from '@angular/core';
import { Item } from '../Items/item';
import { ItemsService } from './items.service';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {

  @Input() item: Item;

  constructor(public itemService: ItemsService) { }

  ngOnInit() {
  }

  async addBookmark() {
    const res: any = await this.itemService.postBookmarks(this.item);
    if (res.res === 'session data set') {
      alert("Bookmark created successfully");
    }
  }

}
