<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Attributes\Guarded;
use Illuminate\Database\Eloquent\Model;
use Override;

class petugas extends Model
{
    protected $fillable = [
        'id_petugas',
        'username',
        'password',
        'nama_petugas',
        'level'
    ];
}
