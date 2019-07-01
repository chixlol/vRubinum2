﻿using System;
using System.Collections.Generic;
using System.Text;

namespace vMt2
{
    enum ServerPacketHeader : byte
    {
        //HEADER_GC_UNKNOWN01 = 0x10,
        //HEADER_GC_SKILL_LEVEL = 0x30,
        //HEADER_GC_INVENTORY_MAX = 0x73,
        //HEADER_GC_UPDATE_PLAYER_POINT = 0x79,
        //HEADER_GC_RUNE = 0x90,

        //Rubinum
        HEADER_GC_CHARACTER_ADD = 0x01,
        HEADER_GC_ATTACK = 0x02,
        HEADER_GC_CHARACTER_MOVE = 0x03,
        HEADER_GC_CHAT = 0x04,
        HEADER_GC_SYNC_POSITION = 0x05,
        HEADER_GC_LOGIN_FAILURE = 0x07,
        HEADER_GC_DEAD = 0x0E,
        HEADER_GC_CHARACTER_POINTS = 0x10,
        HEADER_GC_CHARACTER_POINT_CHANGE = 0x11,
        HEADER_GC_CHARACTER_UPDATE = 0x13,
        HEADER_GC_ITEM_SET = 0x14,
        HEADER_GC_ITEM_SET2 = 0x15,
        HEADER_GC_ITEM_UPDATE = 0x19,
        HEADER_GC_QUICKSLOT_ADD = 0x1C,
        HEADER_GC_GROUND_ITEM_ADD = 0x1A,
        HEADER_GC_GROUND_ITEM_DEL= 0x1B,
        HEADER_GC_ITEM_OWNERSHIP = 0x1F,
        HEADER_GC_LOGIN_SUCCESS4 = 0x20,
        HEADER_GC_PLAYER_SHOP_SET = 0x25,
        HEADER_GC_SHOP_SIGN = 0x27,
        HEADER_GC_PVP = 0x29,
        HEADER_GC_EXCHANGE = 0x2A,
        HEADER_GC_PING = 0x2C,
        HEADER_GC_SCRIPT = 0x2D,
        HEADER_GC_MY_SHOP_SIGN = 0x2F,
        HEADER_GC_SYNC_SHOP_STASH = 0x30,
        HEADER_GC_SYNC_SHOP_OFFTIME = 0x31,
        HEADER_GC_SYNC_SHOP_POSITION = 0x33,
        HEADER_GC_SYNC_SHOP_SLOTS = 0x34,
        HEADER_GC_OWNERSHIP = 0x3E,
        HEADER_GC_FLY_ADD_TARGETING = 0x45,
        HEADER_GC_FLY_CREATE = 0x46,
        HEADER_GC_FLY_TARGETING = 0x47,
        HEADER_GC_GUILD = 0x4B,
        HEADER_GC_SKILL_LEVEL_NEW = 0x4C,
        HEADER_GC_QUEST_INFO = 0x51,
        HEADER_GC_EMPIRE = 0x5A,
        HEADER_GC_TIME = 0x6A,
        HEADER_GC_WALK_MODE = 0x6F,
        HEADER_GC_SPECIAL_EFFECT = 0x72,
        HEADER_GC_NPC_POSITION = 0x73,
        HEADER_GC_Shop_POSITION = 0x74,
        HEADER_GC_CHANNEL = 0x79,
        HEADER_GC_TARGET_UPDATE = 0x7B,
        HEADER_GC_TARGET_CREATE_NEW = 0x7D,
        HEADER_GC_AFFECT_ADD = 0x7E,
        HEADER_GC_AFFECT_REMOVE = 0x7F,
        HEADER_GC_MALL_SET = 0x80,
        HEADER_GC_LAND_LIST = 0x82,
        HEADER_GC_CHAR_ADDITIONAL_INFO = 0x88,
        HEADER_GC_MAIN_CHARACTER4_BGM_VOL = 0x8A,
        HEADER_GC_EXCHANGE_INFO = 0x8E,
        HEADER_GC_AUTH_SUCCESS = 0x96,
        HEADER_GC_UNKNOWN = 0x9F,
        HEADER_GC_UNKNOWN02 = 0xA2,
        HEADER_GC_SPECIFIC_EFFECT = 0xD0,
        HEADER_GC_CHARACTER_GOLD = 0xDC,
        HEADER_GC_CHARACTER_GOLD_CHANGE = 0xDD,
        HEADER_GC_INPUT_STATE = 0xDF,
        HEADER_GC_SHOP_RESULTCOUNT = 0xE4,
        HEADER_GC_SHOP_RESULT = 0xE5,
        HEADER_GC_PHASE = 0xFD,
        HEADER_GC_HANDSHAKE = 0xFF,

        HEADER_GC_UNKNOWN01 = 0xE8,
    }
}
