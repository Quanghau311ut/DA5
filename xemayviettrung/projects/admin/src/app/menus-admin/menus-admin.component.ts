import { Component, OnInit } from '@angular/core';
import { MenuService } from 'projects/admin/service/menu.service';

@Component({
  selector: 'app-menus-admin',
  templateUrl: './menus-admin.component.html',
  styleUrls: ['./menus-admin.component.scss']
})

export class MenusAdminComponent implements OnInit {
  myResult: any;
  formData: any = {
    // maMenu: 0,
    // tenMenu: '',
    // moTa: '',
    // trangThai: 'true'
  };
  p: number = 1;
  isEditMode: boolean = false;

  constructor(private menuService: MenuService) { }

  ngOnInit() {
    this.getData();
  }

  getData() {
    this.menuService.getData().then((data: any) => {
      this.myResult = data;
      console.log(this.myResult);
    });
  }

  openCreateModal() {
    this.menuService.Create(this.formData).then(response => {
      console.log(response);
      this.formData = {};
      this.isEditMode = false;
    }, error => {
      console.log(error);
    })
  }

  openEditModal(item: number) {
    this.menuService.getDatabyID(item).then((editData: any) => {
      this.formData = editData;
      this.isEditMode = true;
    }).catch(error => {
      console.error('Lỗi', error);
    });
  }

  submitForm() {
    if (this.isEditMode) {
      this.menuService.edit(this.formData.maMenu, this.formData).then(response => {
        console.log('Cập nhật thành công', response);
        this.closeForm();
        this.getData();
      }).catch(error => {
        console.error('Lỗi', error);
      });
    } else {
      this.menuService.Create(this.formData).then(response => {
        console.log('Thêm bản ghi thành công', response);
        this.closeForm();
        this.getData();
      }).catch(error => {
        console.error('Lỗi thêm bản ghi', error);
      });
    }
  }

  delete(items: number) {
    const confirmResult = confirm("Bạn có chắc chắn muốn xóa menu có mã là: " + `${items}`);
    if (confirmResult) {
      this.menuService.delete(items).then(response => {
        console.log('Xóa thành công', response);
        this.getData();
      }, error => {
        console.error('Lỗi', error);
        this.getData();
      });
    }
  }

  closeForm() {
    const closeElement = document.getElementById('close-form');
    if (closeElement) {
      closeElement.click();
      this.formData = {};
      this.isEditMode = false;
    }
  }
}
