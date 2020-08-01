import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { GalleryComponent } from './gallery/gallery.component';
import { ItemComponent } from './item/item.component';
import { BookmarkListComponent } from './bookmark-list/bookmark-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    GalleryComponent,
    ItemComponent,
    BookmarkListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: GalleryComponent, pathMatch: 'full' },
      { path: 'gallery', component: GalleryComponent },
      { path: 'bookmarks', component: BookmarkListComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
