import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { AuthService } from "../Services/auth.service";

@Injectable({
    providedIn: 'root',
  })
  export class AuthGuard implements CanActivate {
    constructor(
      private as:AuthService, 
      private router: Router
      ) {}
    canActivate(): boolean {
      if(!this.as.isAuthenticated()){
        this.router.navigate(['login']);
      }
  
      return true;
    }
    
  }