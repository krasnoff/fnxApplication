import { Component, OnInit } from '@angular/core';
import { GalleryService } from './gallery.service';
import { Item } from '../Items/item';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

  searchWord: string;
  itemsList: Item[];

  constructor(public galleryService: GalleryService) { }

  ngOnInit() {
  }

  async search() {
    this.itemsList = await this.galleryService.getItems(this.searchWord);
    console.log(this.itemsList);
  }
}
