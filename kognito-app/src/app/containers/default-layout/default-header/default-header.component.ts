import { Component, ElementRef, HostListener, Input, OnInit, ViewChild } from '@angular/core';
import { GlobalService } from 'src/app/services';
import { PlaceHolderService } from 'src/app/services/placeHolder.service';

@Component({
  selector: 'app-default-header',
  templateUrl: './default-header.component.html',
  styleUrls: ['./default-header.component.scss']
})
export class DefaultHeaderComponent implements OnInit {

  sidebarOpen = true;
  isDesktop = this._globalService.isDesktop();
  posts:any[] = [];
  showPopup: boolean = false;

  @Input() sidenavValue: any = false;
  @ViewChild('notificationsButton') notificationsButton: ElementRef | undefined;



  
  constructor(
    private _globalService: GlobalService
    ,private _service: PlaceHolderService
    ,private elementRef: ElementRef
  ) {
    this.autoToggleSidebar();
  }
  ngOnInit(): void {
    this.sidebarOpen = this.sidenavValue.opened
    this.getAllPostsByUserId(1);
  }

  getAllPostsByUserId(id: number) {
    this._service.getPosts(id).subscribe(
      (retorno: any) => {
        this.posts = retorno;
        console.log('RETORNO: ', retorno);
      },
      (error) => {
        console.error(error.message);
      }
    );
  }

  toggle(){
    this.sidebarOpen = !this.sidebarOpen;
    this._globalService._sideNavToggle(null);


  }

  @HostListener('window:resize', ['$event'])
  onResize() {
    this.isDesktop = this._globalService.isDesktop();
    this.autoToggleSidebar();
  }

  autoToggleSidebar(){
    if(this.isDesktop)
    {
      this.sidebarOpen = true;
    }
    else
    {
      this.sidebarOpen = false;
    }

    this._globalService._sideNavToggle(this.sidebarOpen);
  }

  openPopup() {
    this.showPopup = true;
  }

  closePopup() {
    this.showPopup = false;
  }

  getPopupPosition(): any {
    const buttonElement = this.elementRef.nativeElement.querySelector('.example-icon');
    if (buttonElement) {
      const buttonRect = buttonElement.getBoundingClientRect();
      const top = buttonRect.top + buttonRect.height + 8;
      const left = buttonRect.left;
      return { top: `${top}px`, left: `${left}px` };
    }
    return { top: '0', left: '0' };
  }



}
