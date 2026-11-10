<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('formlogin');
});

Route::get('formlogin',[AuthController::class]);
Route::post('formlogin',[AuthController::class]);

