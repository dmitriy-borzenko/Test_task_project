import { UserService } from './../services/user.service';
import { User } from './../models/user';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogComponent } from '../dialog/dialog.component';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

export interface DialogData {
  totalCount: number;
  countActive: number;
}

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})

export class TableComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'active'];
  dataSource: any = null;
  @ViewChild(MatSort) sort: MatSort;

  constructor(public dialog: MatDialog, private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getUsers().subscribe((data: User[]) => {
      this.dataSource = new MatTableDataSource<User>(data);
      this.dataSource.sort = this.sort;
    });
  }

  onChange(e) {
    const id = e.source.id;
    const newUser = this.dataSource.filteredData.filter(item => item.id === +id);
    this.userService.putUsers(newUser[0]).subscribe(() => { });
  }

  openDialog() {
    const dialogRef = this.dialog.open(DialogComponent, {
      width: '450px',
      data: {
        totalCount: this.dataSource.filteredData.length,
        countActive: this.dataSource.filteredData.filter(item => item.active === true).length
      }
    });
  }
}
